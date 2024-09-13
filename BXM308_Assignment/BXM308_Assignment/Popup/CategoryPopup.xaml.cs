using BXM308_Assignment.Model;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BXM308_Assignment.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryPopup
    {
        public CategoryPopup(ObservableCollection<string> list)
        {
            InitializeComponent();
            BindableLayout.SetItemsSource(CategoryList, list);
        }

        private async void Apply_Clicked(object sender, EventArgs e)
        {
            //For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            _ = PopupNavigation.Instance.PopAsync();
            FilterClass filter = new FilterClass();
            MessagingCenter.Send<App, FilterClass>((App)Application.Current, "ApplyingTag", filter);

            await Task.Delay(250);
            IsClicked = false;

        }

        private async void Nav_ClosePoup(object sender, EventArgs e)
        {//For double clicked check
            if (IsClicked)
                return;
            IsClicked = true;
            //Main Function

            _ = PopupNavigation.Instance.PopAsync();
            await Task.Delay(250);
            IsClicked = false;

        }
        private bool IsClicked = false;
    }
}