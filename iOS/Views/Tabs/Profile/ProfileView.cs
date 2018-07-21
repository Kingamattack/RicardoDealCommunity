// File: ProfileView.cs
// Author: Kingamattack
// Date: 12/7/2018

using System.Collections.Generic;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using RicardoDealCommunity.iOS.Views.Tabs.List;
using RicardoDealCommunity.ViewModels;

namespace RicardoDealCommunity.iOS.Views.Tabs.Profile
{
    public partial class ProfileView : MvxViewController<ProfileViewModel>
    {
        public ProfileView() : base(nameof(ProfileView), null) {}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<ProfileView, ProfileViewModel>();
            set.Bind(UserLabel).To(ViewModel => ViewModel.Username);
            set.Bind(ListSegmentedControl).For(sc => sc.SelectedSegment).To(ViewModel => ViewModel.Index);
            set.Apply();

            var source = new ListTableSource(FavoritesTableView);
            this.AddBindings(new Dictionary<object, string>
            {
                { source, "ItemsSource MyDeals" }
            });

            FavoritesTableView.Source = source;
            FavoritesTableView.RowHeight = 100f;
            FavoritesTableView.ReloadData();
        }
    }
}