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

namespace RicardoDealCommunity.iOS.Views.Tabs.Create
{
    [Register ("CreateView")]
    partial class CreateView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView CitiesPickerView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClearButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DescriptionTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField NameTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PriceTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SaveButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CitiesPickerView != null) {
                CitiesPickerView.Dispose ();
                CitiesPickerView = null;
            }

            if (ClearButton != null) {
                ClearButton.Dispose ();
                ClearButton = null;
            }

            if (DescriptionTextField != null) {
                DescriptionTextField.Dispose ();
                DescriptionTextField = null;
            }

            if (NameTextField != null) {
                NameTextField.Dispose ();
                NameTextField = null;
            }

            if (PriceTextField != null) {
                PriceTextField.Dispose ();
                PriceTextField = null;
            }

            if (SaveButton != null) {
                SaveButton.Dispose ();
                SaveButton = null;
            }
        }
    }
}