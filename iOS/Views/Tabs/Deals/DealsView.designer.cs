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

namespace RicardoDealCommunity.iOS.Views.Tabs.Deals
{
    [Register ("DealsView")]
    partial class DealsView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView DealsTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (DealsTableView != null) {
                DealsTableView.Dispose ();
                DealsTableView = null;
            }
        }
    }
}