// File: DealsView.cs
// Author: Kingamattack
// Date: 12/7/2018

using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;

using RicardoDealCommunity.ViewModels;

using Foundation;

using UIKit;

using System.Collections.Generic;

namespace RicardoDealCommunity.iOS.Views.Tabs.Deals
{
    public partial class DealsView : MvxViewController<DealsViewModel>
    {
        public DealsView() : base(nameof(DealsView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // TableViewSource settings
            var source = new DealsTableSource(DealsTableView);
            this.AddBindings(new Dictionary<object, string>
            {
                { source, "ItemsSource Deals" }
            });

            DealsTableView.Source = source;
            DealsTableView.RowHeight = 100f;
            DealsTableView.ReloadData();
        }
    }

    public class DealsTableSource : MvxTableViewSource
    {
        static readonly NSString DealCellIdentifier = new NSString("DealCell");

        public DealsTableSource(UITableView tableView) : base(tableView)
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