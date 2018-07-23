// File: HomeView.cs
// Author: Kingamattack
// Date: 23/7/2018

using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using MvvmCross.Droid.Views;
using RicardoDealCommunity.ViewModels;

namespace RicardoDealCommunity.Droid.Views
{
    [Activity(Label = "View for HomeViewModel")]
    public class HomeView : MvxTabActivity
    {
        protected HomeViewModel HomeViewModel
        {
            get { return base.ViewModel as HomeViewModel; }
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.HomeView);

            TabHost.TabSpec spec;
            Intent intent;

            spec = TabHost.NewTabSpec("List");
            spec.SetIndicator("List");
            spec.SetContent(this.CreateIntentFor(HomeViewModel.MyViewModels[0] as ListViewModel));
            TabHost.AddTab(spec);

            spec = TabHost.NewTabSpec("Create");
            spec.SetIndicator("Create");
            spec.SetContent(this.CreateIntentFor(HomeViewModel.MyViewModels[1] as CreateViewModel));
            TabHost.AddTab(spec);

            spec = TabHost.NewTabSpec("Profile");
            //spec.SetIndicator("3", Resources.GetDrawable(Resource.Drawable.Tab_Tweets));
            spec.SetIndicator("Profile");
            spec.SetContent(this.CreateIntentFor(HomeViewModel.MyViewModels[2] as ProfileViewModel));

            TabHost.AddTab(spec);
        }
    }
}
