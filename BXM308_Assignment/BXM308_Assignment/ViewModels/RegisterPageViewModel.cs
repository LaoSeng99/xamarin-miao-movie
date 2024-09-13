using BXM308_Assignment.Model;
using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BXM308_Assignment.ViewModels
{
    public class RegisterPageViewModel : BaseViewModel
    {

        protected override async void OnLoadCommandExecute()
        {

        }
        private string status;
        public string Status
        {
            get => status;
            set => SetProperty(ref status, value);
        }

        private bool isEmailChecking = false;
        private bool isEmailError = false;
        public bool IsEmailChecking
        {
            get => isEmailChecking;
            set => SetProperty(ref isEmailChecking, value);
        }
        public bool IsEmailError
        {
            get => isEmailError;
            set => SetProperty(ref isEmailError, value);
        }

        private User user;
        public User User
        {
            get => user;
            set => SetProperty(ref user, value);
        }
        public async Task<string> CheckExistEmail(string email)
        {

            if (string.IsNullOrWhiteSpace(email))
                return "* Email field cannot empty ";

            if (email.Contains(" "))
                return "* Email field cannot contains white space ";

            bool isExist = await Firebase.Firebase.CheckEmailExist(email);
            if (isExist)
                return "* The email already exist";

            User = new User()
            {
                Email = email
            };

            return "success";
        }
        public async Task RegisterNewUse()
        {
            User.Id = Guid.NewGuid().ToString();
            User.Image = "RyanReynolds.png";
            await Firebase.Firebase.RegisterNewUser(User);
        }
    }
}
