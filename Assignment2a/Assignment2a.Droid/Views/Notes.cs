using Android.App;
using Android.OS;
using Assignment2a.Core.ViewModels;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Views;

namespace Assignment2a.Droid.Views
{
    [MvxViewFor(typeof(NotesModel))]
    [Activity(Label = "Notes")]
    public class Notes : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Notes);
        }
    }
}
