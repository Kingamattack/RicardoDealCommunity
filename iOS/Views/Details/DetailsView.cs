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
            set.Bind(PriceLabel).SourceDescribed("SelectedDeal.Price + ' €'");
            set.Bind(CityLabel).To(vm => vm.SelectedDeal.City);
            set.Bind(GradeLabel).SourceDescribed("SelectedDeal.Grade + '°'");
            set.Bind(OwnerLabel).To(vm => vm.SelectedDeal.Owner);
            set.Bind(DateLabel).SourceDescribed("SelectedDeal.Date.Month + '/' + SelectedDeal.Date.Day + '/' + SelectedDeal.Date.Year");
            set.Bind(DescriptionTextView).To(vm => vm.SelectedDeal.Description);

            set.Apply();
        }
    }
}