// File: HomeView.cs
// Author: Kingamattack
// Date: 20/7/2018

using System.Collections.Generic;

using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;

using RicardoDealCommunity.ViewModels;

using UIKit;

namespace RicardoDealCommunity.iOS.Views.Tabs
{
    [MvxRootPresentation(WrapInNavigationController = false)]
    public partial class HomeView : MvxTabBarViewController<HomeViewModel>
    {
        private bool _constructed;

        public HomeView()
        {
            _constructed = true;

            ViewDidLoad();
        }

        public override void ViewDidLoad()
        {
            if (!_constructed)
                return;

            base.ViewDidLoad();

            var viewControllers = new List<UIViewController>();
            ViewModel.MyViewModels.ForEach(vm =>
            {
                viewControllers.Add(CreateTabFor(ViewModel.MyViewModels.IndexOf(vm), vm.Name, vm.Icon, vm));
            });

            ViewControllers = viewControllers.ToArray();
        }

        private UIViewController CreateTabFor(int index, string title, string imageName, IMvxViewModel viewModel)
        {
            var controller = new UINavigationController();
            var screen = this.CreateViewControllerFor(viewModel) as UIViewController;
            screen.Title = title;
            screen.TabBarItem = new UITabBarItem(title, UIImage.FromBundle($"Icones/ic_{imageName}/ic_{imageName}.png"), index);

            controller.PushViewController(screen, true);
            controller.NavigationBarHidden = true;
            return controller;
        }
    }
}