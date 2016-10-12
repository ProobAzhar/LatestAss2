using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace Assignment2a.Droid
{
    [Activity(
        Label = "GladoS"
        , MainLauncher = true
        , Theme = "@style/Theme.Splash"
        , NoHistory = true
        , ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}
