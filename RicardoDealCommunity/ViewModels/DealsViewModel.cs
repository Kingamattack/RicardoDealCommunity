// File: DealsViewModel.cs
// Author: Kingamattack
// Date: 12/7/2018

using System.Collections.Generic;

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.ViewModels
{
    public class DealsViewModel : MvxViewModel
    {
        public List<Deal> Deals { get; private set; }

        public DealsViewModel()
        {
            Deals = new List<Deal>
            {
                new Deal
                {
                    Name = "Yeah"
                },
                new Deal
                {
                    Name = "Yeah 2"
                },
                new Deal
                {
                    Name = "Yeah 3"
                },
                new Deal
                {
                    Name = "Yeah 4"
                },
                new Deal
                {
                    Name = "Yeah 5"
                },
            };
        }
    }
}