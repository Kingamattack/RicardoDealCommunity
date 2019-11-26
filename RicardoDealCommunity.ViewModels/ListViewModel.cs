// File: DealsViewModel.cs
// Author: Kingamattack
// Date: 12/7/2018

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

using System.Collections.Generic;
using System.Linq;

namespace RicardoDealCommunity.ViewModels
{
    public class ListViewModel : ChildViewModel
    {
        public Deal Item { get; set; }

        List<Deal> deals = new List<Deal>();
        public List<Deal> Deals 
        {
            get => deals;
            set
            {
                deals = value;
                RaisePropertyChanged(() => Deals);
            }
        }

        private readonly DealService dealService;

        public new MvxCommand GoToChildCommand => new MvxCommand(() => ShowViewModel<DetailsViewModel, Deal>(Item));

        public string SeekingText { get; set; }

        public ListViewModel()
        {
            dealService = new DealService();

            Deals = dealService.AllDeals();
            Name = "List";
            Icon = "deals";
        }

        public void UpdateDeals()
        {
            if (string.IsNullOrWhiteSpace(SeekingText))
                Deals = dealService.AllDeals();
            else
                Deals = dealService.AllDeals().Where(d => d.Name.ToLower().Contains(SeekingText.ToLower())).Select(p => p).ToList();
        }
    }
}