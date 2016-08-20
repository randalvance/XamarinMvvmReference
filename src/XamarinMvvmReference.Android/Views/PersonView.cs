using Android.App;
using MvvmCross.Droid.Views;

namespace XamarinMvvmReference.Android.Views
{
    [Activity(Label = "View/Edit Person")]
    public class PersonView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.PersonView);
        }
    }
}