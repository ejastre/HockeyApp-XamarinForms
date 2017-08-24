
using Android.App;
using Android.Content.PM;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace App3.Droid
{
    [Activity(Label = "App3", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private string AppId = "5c6138a83a6c4464bac8e24817e260ad";

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            CrashManager.Register(this, AppId);
            // in your main activity OnCreate-method add:
            MetricsManager.Register(Application, AppId);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            //ActionBar.SetIcon(Android.Resource.Color.Transparent);

            LoadApplication(new App());
        }
    }
}

