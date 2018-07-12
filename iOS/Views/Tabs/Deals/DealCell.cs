// File: DealCell.cs
// Author: Kingamattack
// Date: 12/7/2018

using System;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;

using Foundation;

using UIKit;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.iOS.Views.Tabs.Deals
{
    public partial class DealCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("DealCell");
        public static readonly UINib Nib;

        static DealCell()
        {
            Nib = UINib.FromName("DealCell", NSBundle.MainBundle);
        }

        protected DealCell(IntPtr handle) : base(handle)
        {
            this.DelayBind(() =>
            {
                this.CreateBinding(NameLabel).To<Deal>(deal => deal.Name).Apply();
                this.CreateBinding(DateLabel).To<Deal>(deal => deal.Date).Apply();
                this.CreateBinding(PriceLabel).To<Deal>(deal => deal.Price).Apply();
                this.CreateBinding(OwnerLabel).To<Deal>(deal => deal.Owner).Apply();
                this.CreateBinding(ThumbnailImageView).To<Deal>(deal => deal.Picture).Apply();
            });
        }
    }
}