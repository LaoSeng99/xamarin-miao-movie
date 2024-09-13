using BXM308_Assignment.Layout;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: ExportFont("AorusTitle_Regular.ttf")]
[assembly: ExportFont("AorusFont_Bold.ttf")]
[assembly: ExportFont("AorusFont_BoldItalic.ttf")]
[assembly: ExportFont("AorusFont_Italic.ttf")]
[assembly: ExportFont("AorusFont_Regular.ttf")]
namespace BXM308_Assignment
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Sharpnado.MaterialFrame.Initializer.Initialize(loggerEnable: false, debugLogEnable: false);
            var ppi = DeviceDisplay.MainDisplayInfo.Density;
            if (ppi >= 2.75 && ppi <= 2.9)
                dictionary.MergedDictionaries.Add(Density2_75.SharedInstance);
            else
                dictionary.MergedDictionaries.Add(Density3.SharedInstance);

            MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnStart()
        {

        }
        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
