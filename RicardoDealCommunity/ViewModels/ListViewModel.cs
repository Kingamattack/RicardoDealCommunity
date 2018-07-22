// File: DealsViewModel.cs
// Author: Kingamattack
// Date: 12/7/2018

using System.Collections.Generic;
using System.Linq;

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

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

        public new MvxCommand GoToChildCommand
        {
            get => new MvxCommand(() => ShowViewModel<DetailsViewModel>(Item));
        }

        public string SeekingText { get; set; }

        public ListViewModel()
        {
            Deals = LocalData.AllDeals();
            Name = "List";
            Icon = "deals";
        }

        public void UpdateDeals()
        {
            if (string.IsNullOrWhiteSpace(SeekingText))
                Deals = LocalData.AllDeals();
            else
                Deals = LocalData.AllDeals().Where(d => d.Name.ToLower().Contains(SeekingText.ToLower())).Select(p => p).ToList();
        }
    }
}