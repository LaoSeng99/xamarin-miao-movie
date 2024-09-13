using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.Popup;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentPage : ContentPage
    {
        public PaymentPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            _ = ClosePage();
            return true;
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(200);
            await PageContent.FadeTo(1, 200, Easing.Linear);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        //========== Navigate Page ===============
        private async void Nav_ClosePage(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function
            await ClosePage();

            await Task.Delay(250);
            IsClicked = false;
        }
        //========== Function Method ===========
        private async Task ClosePage()
        {
            var result = await DisplayAlert("Close Page", "The payment is not complete, Are you sure want to quit?", "Quit", "NO");
            if (!result)
                return;

            await PageContent.FadeTo(0, 200, Easing.Linear);
            await PopupNavigation.Instance.PushAsync(BookingCloseTransitionPopup);
            _ = Navigation.PopAsync(false);

            MessagingCenter.Send<App, bool>((App)Application.Current, "PaymentPopupShow", false);
        }
        //========== Object/Bool Area =============
        private BookingCloseTransitionPopup BookingCloseTransitionPopup = new BookingCloseTransitionPopup(300);
        private bool IsClicked = false;

        private async void Complete_Clicked(object sender, EventArgs e)
        {
            if (IsClicked)
                return;
            IsClicked = true;

            await PageContent.FadeTo(0, 200, Easing.Linear);
            await PopupNavigation.Instance.PushAsync(BookingCloseTransitionPopup);
            _ = Navigation.PopAsync(false);

            MessagingCenter.Send<App, bool>((App)Application.Current, "PaymentPopupShow", true);
            await Task.Delay(250);
            IsClicked = false;
        }
    }
}