// File: ProfileView.cs
// Author: Kingamattack
// Date: 12/7/2018

using MvvmCross.iOS.Views;
using RicardoDealCommunity.ViewModels;

namespace RicardoDealCommunity.iOS.Views.Tabs.Profile
{
    public partial class ProfileView : MvxViewController<ProfileViewModel>
    {
        public ProfileView() : base(nameof(ProfileView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}