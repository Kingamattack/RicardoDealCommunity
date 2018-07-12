// File: DetailsView.cs
// Author: Kingamattack
// Date: 13/7/2018

using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

using RicardoDealCommunity.ViewModels;

using UIKit;

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
            set.Bind(PictureImageView).For(imageView => imageView.Image).To(detailsViewModel => new UIImage(detailsViewModel.CurrentDeal.Picture));
            set.Bind(NameLabel).To(detailsViewModel => detailsViewModel.CurrentDeal.Name);
            set.Bind(PriceLabel).To(detailsViewModel => detailsViewModel.CurrentDeal.Price);
            set.Bind(OwnerLabel).To(detailsViewModel => detailsViewModel.CurrentDeal.Owner);
            set.Apply();
        }
    }
}