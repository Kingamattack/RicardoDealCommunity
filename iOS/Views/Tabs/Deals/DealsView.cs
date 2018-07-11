// File: DealsView.cs
// Author: Kingamattack
// Date: 12/7/2018

using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;

using RicardoDealCommunity.ViewModels;

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

            var set = this.CreateBindingSet<DealsView, DealsViewModel>();
            set.Bind(DealsTableView).For(tableView => tableView.DataSource).To(viewModel => viewModel.Deals);
            set.Apply();
        }
    }
}