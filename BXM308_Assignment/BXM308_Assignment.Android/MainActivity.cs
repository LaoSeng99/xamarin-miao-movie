using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using CarouselView.FormsPlugin.Droid;
using Android.Views;
using Plugin.Toasts;
using FFImageLoading.Forms.Platform;
using System.Threading.Tasks;
using Android.Content;
using static BXM308_Assignment.Droid.MainActivity;
using BXM308_Assignment.Interfaces;
using Xamarin.Forms;


[assembly: Dependency(typeof(AppRestartService))]
namespace BXM308_Assignment.Droid
{

    [Activity(Label = "BXM308_Assignment", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
           
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            CachedImageRenderer.Init(enableFastRenderer: true);
            Rg.Plugins.Popup.Popup.Init(this);

            CarouselViewRenderer.Init();
         
            LoadApplication(new App());

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        public class AppRestartService : IAppService
        {
            public void RestartApp()
            {
                var context = Android.App.Application.Context;
                Intent mStartActivity = new Intent(context, typeof(MainActivity));
                mStartActivity.AddFlags(ActivityFlags.ClearTop | ActivityFlags.NewTask);
                context.StartActivity(mStartActivity);

                // Close the current activity to mimic restart
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
            }
        }
    }
}