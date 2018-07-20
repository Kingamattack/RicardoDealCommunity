// File: DealCell.cs
// Author: Kingamattack
// Date: 12/7/2018

using System;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;

using Foundation;

using UIKit;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.iOS.Views.Tabs.List
{
    public partial class DealCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("DealCell");
        public static readonly UINib Nib;

        MvxImageViewLoader _imageHelper;

        static DealCell()
        {
            Nib = UINib.FromName("DealCell", NSBundle.MainBundle);
        }

        protected DealCell(IntPtr handle) : base(handle)
        {
            _imageHelper = new MvxImageViewLoader(() => ThumbnailImageView);
            this.DelayBind(() =>
            {
                this.CreateBinding(NameLabel).To<Deal>(deal => deal.Name).Apply();
                this.CreateBinding(PriceLabel).To<Deal>(deal => deal.Price).Apply();
                this.CreateBinding(OwnerLabel).To<Deal>(deal => deal.Owner).Apply();
                this.CreateBinding(DateLabel).To<Deal>(deal => deal.Date).WithConversion("StringFormat", "MM/dd/yyyy").Apply();
                this.CreateBinding(CityLabel).To<Deal>(deal => deal.City).Apply();
                this.CreateBinding(GradeLabel).To<Deal>(deal => deal.Grade).Apply();
            });
        }
    }
}