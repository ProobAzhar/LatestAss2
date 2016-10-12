using Android.App;
using Android.OS;
using Assignment2a.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace Assignment2a.Droid.Views
{
    [MvxViewFor(typeof(EventsModel))]
    [Activity(Label = "Events")]
    public class Events : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Events);
        }
    }
}
