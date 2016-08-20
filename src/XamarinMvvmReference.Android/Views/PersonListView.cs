
using Android.App;
using MvvmCross.Droid.Views;

namespace XamarinMvvmReference.Android.Views
{
    [Activity(Label = "Person List")]
    public class PersonListView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.PersonListView);
        }
    }
}