using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CloseTransitionPopup 
    {
        public CloseTransitionPopup(int millisecond)
        {
            time = millisecond;
            InitializeComponent();
        }

        private int time = 0;
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(time);
            _ = PopupNavigation.Instance.PopAsync();

        }
    }
}