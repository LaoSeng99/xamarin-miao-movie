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
    public partial class PhotoViewPopup
    {
        public PhotoViewPopup(ObservableCollection<MovieImage> imageList)
        {

            InitializeComponent();
            ImageList.ItemsSource = imageList;
        }

    }
}