using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookingReviewPopup
    {
        private BookingPageViewModel viewModel;
        public BookingReviewPopup(TicketVM ticket, RoomSeatContainerVM selected, RoomTime room)
        {
            InitializeComponent();

            viewModel = new BookingPageViewModel(ticket, selected, room);
            this.BindingContext = viewModel;

            MessagingCenter.Subscribe<App, bool>((App)Application.Current, "PaymentPopupShow", async (sender, isSuccess) =>
            {

                this.IsVisible = true;
                await this.FadeTo(1, 200, Easing.Linear);
                await Task.Delay(1000);

                await viewModel.PaymentComplete(isSuccess);

                _ = LoadingAnimation.ScaleTo(1.25, 450, Easing.Linear);

                await Task.Delay(200);

                _ = LoadingAnimation.ScaleTo(1, 200, Easing.Linear);
                IsRedirecting = false;
            });

        }
        protected override void OnAppearing()
        {
            if (this.BindingContext is BaseViewModel vm)
                vm.LoadCommand.Execute(null);
        }
        private async void Cancel_Clicked(object sender, EventArgs e)
        {
            //For double clicked check
            if (IsClicked || IsRedirecting)
                return;
            IsClicked = true;
            //Main Function
            MessagingCenter.Unsubscribe<App, bool>((App)Application.Current, "PaymentPopupShow");

            await PopupNavigation.Instance.PopAsync();

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Continue_Clicked(object sender, EventArgs e)
        {         //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function
            IsRedirecting = true;
            LoadContainer.IsVisible = true;

            await LoadContainer.FadeTo(1, 100, Easing.Linear);
            _ = LoadingAnimation.FadeTo(1, 350, Easing.Linear);
            await LoadingAnimation.TranslateTo(0, 0, 400, Easing.Linear);

            await Task.Delay(500);

            await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(600));
            await Task.Delay(200);

            this.Opacity = 0;
            this.IsVisible = false;
            viewModel.StatusText = "Waiting for payment...";

            _ = Navigation.PushAsync(new PaymentPage(), false);

            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Close_Review_Clicked(object sender, EventArgs e)
        {
            if (IsRedirecting || IsClicked)
                return;

            IsClicked = true;
            MessagingCenter.Unsubscribe<App, bool>((App)Application.Current, "PaymentPopupShow");
            if (viewModel.Success)
            {

                MessagingCenter.Send<App>((App)Application.Current, "Nav_ToTicket");
                MessagingCenter.Unsubscribe<App>((App)Application.Current, "ApplyingTag");
                await PopupNavigation.Instance.PushAsync(new TransitionPopup(600, true));
                await Navigation.PopToRootAsync(false);
                IsClicked = false;
                return;
            }

            await LoadContainer.FadeTo(0, 150, Easing.Linear);
            LoadContainer.IsVisible = false;
            viewModel.ResetProperty();
            LoadContainer.Scale = 1;
            LoadingAnimation.TranslationY = 60;
            await Task.Delay(250);
            IsClicked = false;
        }
        public static bool IsRedirecting = false;
        private bool IsClicked = false;

        private void Block_Panel(object sender, EventArgs e)
        {
            return;
        }
    }
}