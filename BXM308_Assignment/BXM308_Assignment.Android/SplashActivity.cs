using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BXM308_Assignment.Droid
{
    [Activity(Label = "MiaoMovie", Theme = "@style/MyTheme.Splash",
      MainLauncher = true, NoHistory = true, ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            await Task.Delay(500);

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}