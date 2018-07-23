// File: ListView.cs
// Author: Kingamattack
// Date: 23/7/2018

using Android.App;
using Android.OS;

using MvvmCross.Droid.Views;

using RicardoDealCommunity.ViewModels;

namespace RicardoDealCommunity.Droid.Views
{
    [Activity(Label = "ListView", MainLauncher = true)]
    public class ListView : MvxActivity<ListViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ListView);
        }
    }
}