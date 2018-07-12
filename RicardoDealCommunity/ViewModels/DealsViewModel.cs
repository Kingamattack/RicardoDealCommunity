// File: DealsViewModel.cs
// Author: Kingamattack
// Date: 12/7/2018

using System.Collections.Generic;

using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.ViewModels
{
    public class DealsViewModel : MvxViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public List<Deal> Deals 
        { 
            get
            {
                return new List<Deal> { new Deal { Name = "Deal 1" }, new Deal { Name = "Deal 2" }, new Deal { Name = "Deal 3" } };
            } 
        }

        public DealsViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }
    }
}