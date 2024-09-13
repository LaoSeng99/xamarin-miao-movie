using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransitionPopup
    {
        public TransitionPopup(int millisecond)
        {
            time = millisecond;
            InitializeComponent();
        }
        public TransitionPopup(int millisecond, bool popToRoot = false)
        {
            time = millisecond;
            PoptoRoot = popToRoot;
            InitializeComponent();

        }
        private int time = 0;
        private bool PoptoRoot;
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (time != 0)
            {
                await Task.Delay(time);
                if (!PoptoRoot)
                    _ = PopupNavigation.Instance.PopAsync();
                else
                    _ = PopupNavigation.Instance.PopAllAsync();
            }


        }
    }
}