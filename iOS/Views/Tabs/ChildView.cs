// File: ChildView.cs
// Author: Kingamattack
// Date: 20/7/2018
using System;
using CoreGraphics;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using RicardoDealCommunity.ViewModels;
using UIKit;

namespace RicardoDealCommunity.iOS.Views.Tabs
{
    public partial class ChildView : MvxViewController<ChildViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            EdgesForExtendedLayout = UIRectEdge.None;
            //View.BackgroundColor = UIColor.FromRGB(new Random().Next(0, 255), new Random().Next(0, 255), new Random().Next(0, 255));
            View.BackgroundColor = UIColor.DarkGray;

            var button = new UIButton(new CGRect(200, 200, 80, 40));
            button.SetTitle("GO", UIControlState.Normal);
            Add(button);

            var set = this.CreateBindingSet<ChildView, ChildViewModel>();
            set.Bind(button).To(vm => vm.GoToChildCommand);
            set.Apply();
        }
    }
}