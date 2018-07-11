// File: ProfileView.cs
// Author: Kingamattack
// Date: 12/7/2018
using System;

using UIKit;

namespace RicardoDealCommunity.iOS.Views.Tabs.Profile
{
    public partial class ProfileView : UIViewController
    {
        public ProfileView() : base("ProfileView", null)
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

