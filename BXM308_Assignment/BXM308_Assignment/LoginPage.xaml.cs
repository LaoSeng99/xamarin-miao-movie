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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            RegisterInfos = (new List<(Entry, Label, string)>()
            {
                (Login_Email ,Error_Email,"Email"),
                (Login_Password ,Error_Password,"Password"),
            });

        }
        protected async override void OnAppearing()
        {
            if (this.BindingContext is BaseViewModel viewModel)
                viewModel.LoadCommand.Execute(null);

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

        //========== Function Method ===========
        private string CheckInputFormat(string input, string type)
        {
            if (string.IsNullOrEmpty(input))
                return $"The {type} cannot empty";
            if (input.Contains(" ") && type != "Username")
                return $"The {type} cannot contains white space";
            return "Success";
        }
        private async void Login_Clicked(object sender, EventArgs e)
        {//For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            Login_Email.Unfocus();
            Login_Password.Unfocus();
            LoginChecking.IsVisible = true;
            int correctNum = RegisterInfos.Count;
            string email = string.Empty, password = string.Empty;
            foreach (var item in RegisterInfos)
            {

                var result = CheckInputFormat(item.Item1.Text, item.Item3);
                if (result == "Success")
                {
                    item.Item2.IsVisible = false;

                    if (item.Item3 == "Email")
                        email = item.Item1.Text;
                    if (item.Item3 == "Password")
                        password = item.Item1.Text;
                    continue;
                }

                //if didnt reduce, mean success
                correctNum--;
                item.Item2.IsVisible = true;
                item.Item2.Text = result;
            }

            if (correctNum != RegisterInfos.Count)
            {
                LoginChecking.IsVisible = false;
                await Task.Delay(250);
                IsClicked = false;
                return;
            }

            UserVM loginResult = await Firebase.Firebase.LogIn(email, password);

            if (loginResult == null)
            {
                foreach (var item in RegisterInfos)
                {
                    if (item.Item3 == "Email")
                    {
                        item.Item2.Text = "* The email does'nt exist or the wrong password";
                        item.Item2.IsVisible = true;
                    }

                    if (item.Item3 == "Password")
                    {
                        item.Item1.Text = "";
                        item.Item2.IsVisible = false;
                    }
                }
                LoginChecking.IsVisible = false;
                await Task.Delay(250);
                IsClicked = false;
                return;
            }

            LoginChecking.IsVisible = false;
            MessagingCenter.Send<App, UserVM>((App)Application.Current, "LogInSuccess", loginResult);
            await PageContent.FadeTo(0, 200, Easing.Linear);

            if (MovieBookingTicket.IsBookingToLogin)
            {
                _ = PopupNavigation.Instance.PushAsync(new CloseTransitionPopup(700));
                await Task.Delay(150);
                //Close two page
                _ = Navigation.PopAsync(false);
                _ = Navigation.PopAsync(false);
                MovieBookingTicket.IsBookingToLogin = false;
                return;
            }
            _ = PopupNavigation.Instance.PushAsync(CloseTransition);
            await Task.Delay(100);
            await Navigation.PopToRootAsync(false);
            await Task.Delay(250);
            IsClicked = false;
        }
        private async Task ClosePage()
        {
            _ = PopupNavigation.Instance.PushAsync(CloseTransition);
            await Task.Delay(200);
            await Navigation.PopAsync(false);
        }
        private CloseTransitionPopup CloseTransition = new CloseTransitionPopup(400);
        public List<(Entry, Label, string)> RegisterInfos;

        private bool IsClicked = false;



    }
}