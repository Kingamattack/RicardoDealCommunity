﻿// File: DealsView.cs
// Author: Kingamattack
// Date: 12/7/2018

using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

using RicardoDealCommunity.ViewModels;

using Foundation;

using UIKit;

using System.Collections.Generic;

namespace RicardoDealCommunity.iOS.Views.Tabs.List
{
    public partial class ListView : MvxViewController<ListViewModel>
    {
        public ListView() : base(nameof(ListView), null) {}

        ListTableSource source;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            source = new ListTableSource(ListTableView);
            this.AddBindings(new Dictionary<object, string>
            {
                { source, "ItemsSource Deals" },
                { DealSearchBar, "Text SeekingText"}
            });

            this.CreateBinding(source).For(s => s.SelectedItem).To<ListViewModel>(vm => vm.Item).Apply();
            this.CreateBinding(source).For(s => s.SelectionChangedCommand).To<ListViewModel>(vm => vm.GoToChildCommand).Apply();

            DealSearchBar.TextChanged += (sender, e) =>  
            {
                ViewModel.UpdateDeals();
            }; 

            ListTableView.Source = source;
            ListTableView.RowHeight = 110f;
            ListTableView.ReloadData();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            ListTableView.ReloadData();
        }
    }

    public class ListTableSource : MvxTableViewSource
    {
        static readonly NSString DealCellIdentifier = new NSString("DealCell");

        public ListTableSource(UITableView tableView) : base(tableView)
        {
            tableView.RegisterNibForCellReuse(UINib.FromName("DealCell", NSBundle.MainBundle), DealCellIdentifier);
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var dealCell = TableView.DequeueReusableCell(DealCellIdentifier, indexPath) as DealCell;
            return dealCell;
        }
    }
}