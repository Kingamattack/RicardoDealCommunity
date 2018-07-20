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

namespace RicardoDealCommunity.iOS.Views.Tabs.List
{
    [Register ("ListView")]
    partial class ListView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView ListTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (ListTableView != null) {
                ListTableView.Dispose ();
                ListTableView = null;
            }
        }
    }
}