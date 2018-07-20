// File: DealsViewModel.cs
// Author: Kingamattack
// Date: 12/7/2018

using System.Collections.Generic;

using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

namespace RicardoDealCommunity.ViewModels
{
    public class ListViewModel : ChildViewModel
    {
        readonly IMvxNavigationService _navigationService;

        public Deal Item { get; set; }

        public List<Deal> Deals { get; set; }

        public MvxCommand<Deal> SelectItemCommand { get; private set; }

        public ListViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            SelectItemCommand = new MvxCommand<Deal>(HandleAction);

            Deals = LocalData.GetDeals();
        }

        public ListViewModel()
        {
            SelectItemCommand = new MvxCommand<Deal>(HandleAction);
            Deals = LocalData.GetDeals();
            Name = "List";
            Icon = "deals";
        }

        void HandleAction(Deal obj)
        {
            Item = obj;
            _navigationService.Navigate<DetailsViewModel, Deal>(Item);
        }
    }
}