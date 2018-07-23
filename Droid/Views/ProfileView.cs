// File: ProfileView.cs
// Author: Kingamattack
// Date: 23/7/2018

using Android.App;
using Android.OS;

using MvvmCross.Droid.Views;

namespace RicardoDealCommunity.Droid.Views
{
    [Activity(Label = "ProfileView")]
    public class ProfileView : MvxActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProfileView);
        }
    }
}
