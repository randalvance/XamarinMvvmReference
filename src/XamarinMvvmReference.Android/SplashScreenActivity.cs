
using Android.App;
using Android.Util;
using MvvmCross.Droid.Views;

namespace XamarinMvvmReference.Android
{
    [Activity(Label = "My App", MainLauncher = true, NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreenActivity : MvxSplashScreenActivity
    {
        public SplashScreenActivity() : base(Resource.Layout.SplashScreen)
        {
            Log.Info("Test", "Test String");
        }
    }
}