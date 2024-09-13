using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using BXM308_Assignment.Popup;
using BXM308_Assignment.ViewModels;
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
    public partial class UserLoginPage : ContentPage
    {

        public UserLoginPage()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {
            await Task.Delay(200);
            await PageContent.FadeTo(1, 200, Easing.Linear);
        }
        protected override bool OnBackButtonPressed()
        {
            _ = ClosePage();
            return true;
        }

        //========== Get Data =============
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
        private async void Nav_RegisterPage(object sender, EventArgs e)
        {
            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage(), false);

            await Task.Delay(250);
            IsClicked = false;

        }
        private async void Nav_LoginPage(object sender, EventArgs e)
        {
            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            await PopupNavigation.Instance.PushAsync(new BookingTransitionPopup(400));
            await App.Current.MainPage.Navigation.PushAsync(new LoginPage(), false);

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