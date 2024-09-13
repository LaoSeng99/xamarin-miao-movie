using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.Popup;
using BXM308_Assignment.ViewModels;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        private SettingPageViewModel viewModel;
        public SettingPage(bool isLogged)
        {
            InitializeComponent();

            viewModel = new SettingPageViewModel(isLogged);
            this.BindingContext = viewModel;
        }
        protected override bool OnBackButtonPressed()
        {
            _ = ClosePage();
            return true;
        }
        protected async override void OnAppearing()
        {
            if (this.BindingContext is BaseViewModel viewModel)
                viewModel.LoadCommand.Execute(null);

            await Task.Delay(200);
            await PageContent.FadeTo(1, 200, Easing.Linear);
        }
        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
        //========== Get Data =============
        //========== Navigate Page ===============
        private async void Nav_Setting_Popup(object sender, EventArgs e)
        {
            var stack = sender as StackLayout;
            var tapGesture = stack.GestureRecognizers[0] as TapGestureRecognizer;
            var popupTo = tapGesture.CommandParameter.ToString();

            switch (popupTo)
            {
                case "EditProfiles":
                    break;
                case "ChangesPassword":
                    break;
                case "PurchaseHistory":
                    break;
                case "PaymentMethods":
                    break;
                case "LogOut":
                    break;
            }
            await Task.Delay(250);
            IsClicked = false;
        }
        private async void Nav_Logout(object sender, EventArgs e)
        {  //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function 

            var confirmLogout = await DisplayAlert("Log out", "Are you sure want to log out?", "Log out", "No");
            if (confirmLogout)
            {
                await PageContent.FadeTo(0, 200, Easing.Linear);

                _ = AppPreferences.SetString("UserId", "");
                await PopupNavigation.Instance.PushAsync(BookingCloseTransitionPopup);
                MessagingCenter.Send<App>((App)Application.Current, "LogOut");
                viewModel.IsLogged = false;
                await PageContent.FadeTo(1, 200, Easing.Linear);
            }

            await Task.Delay(250);
            IsClicked = false;
            return;
        }
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
            await PageContent.FadeTo(0, 200, Easing.Linear);
            await PopupNavigation.Instance.PushAsync(BookingCloseTransitionPopup);
            _ = Navigation.PopAsync(false);
        }
        //========== Object/Bool Area =============
        private BookingCloseTransitionPopup BookingCloseTransitionPopup = new BookingCloseTransitionPopup(300);
        private bool IsClicked = false;


    }
}