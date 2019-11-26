// File: DealCell.cs
// Author: Kingamattack
// Date: 12/7/2018

using Foundation;

using MvvmCross.Binding.BindingContext;
using MvvmCross.Binding.iOS.Views;

using RicardoDealCommunity.Models;

using System;

using UIKit;

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
                var set = this.CreateBindingSet<DealCell, Deal>();

                set.Bind(NameLabel).To(deal => deal.Name);
                set.Bind(PriceLabel).SourceDescribed("Price + ' €'");
                set.Bind(OwnerLabel).To(deal => deal.Owner);
                set.Bind(DateLabel).SourceDescribed("Date.Month + '/' + Date.Day + '/' + Date.Year");
                set.Bind(CityLabel).To(deal => deal.City);
                set.Bind(GradeLabel).SourceDescribed("Grade + '°'");

                set.Apply();
            });
        }
    }
}