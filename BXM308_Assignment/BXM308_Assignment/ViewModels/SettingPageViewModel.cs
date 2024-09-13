using BXM308_Assignment.PageViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BXM308_Assignment.ViewModels
{
    public class SettingPageViewModel : BaseViewModel
    {
        public SettingPageViewModel(bool isLogged)
        {
            IsLogged = isLogged;
        }
        protected override async void OnLoadCommandExecute()
        {
        }
        private bool isLogged;
        public bool IsLogged
        {
            get => isLogged;
            set => SetProperty(ref isLogged, value);
        }

    }
}
