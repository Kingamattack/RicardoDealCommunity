// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace RicardoDealCommunity.iOS.Views.Tabs.Profile
{
    [Register ("ProfileView")]
    partial class ProfileView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView FavoritesTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl ListSegmentedControl { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView UserImageView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel UserLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (FavoritesTableView != null) {
                FavoritesTableView.Dispose ();
                FavoritesTableView = null;
            }

            if (ListSegmentedControl != null) {
                ListSegmentedControl.Dispose ();
                ListSegmentedControl = null;
            }

            if (UserImageView != null) {
                UserImageView.Dispose ();
                UserImageView = null;
            }

            if (UserLabel != null) {
                UserLabel.Dispose ();
                UserLabel = null;
            }
        }
    }
}