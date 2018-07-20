// File: DetailsView.cs
// Author: Kingamattack
// Date: 13/7/2018

using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;

using RicardoDealCommunity.ViewModels;

namespace RicardoDealCommunity.iOS.Views.Details
{
    public partial class DetailsView : MvxViewController<DetailsViewModel>
    {
        public DetailsView() : base(nameof(DetailsView), null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<DetailsView, DetailsViewModel>();
            set.Bind(NameLabel).To(vm => vm.SelectedDeal.Name);
            set.Bind(PriceLabel).To(vm => vm.SelectedDeal.Price);
            set.Bind(CityLabel).To(vm => vm.SelectedDeal.City);
            set.Bind(OwnerLabel).To(vm => vm.SelectedDeal.Owner);

            set.Apply();
        }
    }
}