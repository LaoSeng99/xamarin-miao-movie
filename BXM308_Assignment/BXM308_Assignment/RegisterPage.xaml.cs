
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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            viewModel = new RegisterPageViewModel();
            this.BindingContext = viewModel;

            RegisterInfos = (new List<(Entry, Label, string)>()
            {
                (Register_Username ,Error_Username,"Username"),
                (Register_Password ,Error_Password,"Password"),
                (Register_Re_EnterPassword,Error_Re_EnterPassword,"Re_EnterPassword"),
                (Register_Phone ,Error_Phone,"Phone"),
            });


        }
        public List<(Entry, Label, string)> RegisterInfos;
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
        private async Task ClosePage()
        {
            if (IsPhaseTwo)
            {
                await Step2Container.FadeTo(0, 150, Easing.Linear);
                Step2Container.IsVisible = false;
                IsPhaseTwo = false;
                Step1Container.IsVisible = true;
                await Step1Container.FadeTo(1, 150, Easing.Linear);
                return;
            }
            _ = PopupNavigation.Instance.PushAsync(CloseTransition);
            await Task.Delay(200);
            await Navigation.PopAsync(false);
        }
        private string CheckInputFormat(string input, string type)
        {
            if (string.IsNullOrEmpty(input))
                return $"The {type} cannot empty";
            if (input.Contains(" ") && type != "Username")
                return $"The {type} cannot contains white space";
            return "Success";
        }
        //========== Object/Bool Area =============
        private CloseTransitionPopup CloseTransition = new CloseTransitionPopup(400);
        private RegisterPageViewModel viewModel;

        private bool IsClicked = false;
        private bool IsPhaseTwo = false;
        private async void Register_CheckEmail(object sender, EventArgs e)
        {//For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            Register_Email.Unfocus();

            viewModel.IsEmailChecking = true;

            var email = Register_Email.Text;
            var result = await viewModel.CheckExistEmail(email);

            viewModel.IsEmailChecking = false;

            if (result == "success")
            {
                viewModel.IsEmailError = false;
                await Step1Container.FadeTo(1, 150, Easing.Linear);
                Step1Container.IsVisible = false;
                Step2Container.IsVisible = true;
                await Step2Container.FadeTo(1, 150, Easing.Linear);
                IsPhaseTwo = true;
                return;
            }
            ErrorEmailMessage.Text = result;
            viewModel.IsEmailError = true;

            await Task.Delay(250);
            IsClicked = false;

        }
        private async void RegisterStep2_Continue(object sender, EventArgs e)
        {//For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            int correctNum = RegisterInfos.Count;
            foreach (var item in RegisterInfos)
            {
                var result = CheckInputFormat(item.Item1.Text, item.Item3);
                if (result == "Success")
                {
                    item.Item2.IsVisible = false;
                    continue;
                }
                //if didnt reduce, mean success
                correctNum--;
                item.Item2.IsVisible = true;
                item.Item2.Text = result;
            }

            if (correctNum != RegisterInfos.Count)
                return;

            var checkPassword = RegisterInfos.Where(c => c.Item3 == "Password" || c.Item3 == "Re_EnterPassword");
            var checkSame = checkPassword.Select(C => C.Item1.Text).Distinct();
            //Mean Not Same Return false
            if (checkSame.Count() != 1)
            {
                var reEnter = checkPassword.FirstOrDefault(c => c.Item3 == "Re_EnterPassword");
                reEnter.Item1.Text = "";
                reEnter.Item2.IsVisible = true;
                reEnter.Item2.Text = "The password did'nt same";
                return;
            }


            foreach (var item in RegisterInfos)
            {
                if (item.Item3 == "Re_EnterPassword")
                    continue;

                switch (item.Item3)
                {
                    case "Username":
                        viewModel.User.Name = item.Item1.Text;
                        continue;
                    case "Password":
                        viewModel.User.Password = item.Item1.Text;
                        continue;
                    case "Phone":
                        viewModel.User.Phone = item.Item1.Text;
                        continue;
                }
            }

            await viewModel.RegisterNewUse();
            await Navigation.PopAsync();


            await Task.Delay(250);
            IsClicked = false;

        }
    }
}