// File: DealsViewModel.cs
// Author: Kingamattack
// Date: 12/7/2018

using System.Collections.Generic;
using System.Windows.Input;

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

namespace RicardoDealCommunity.ViewModels
{
    public class ListViewModel : ChildViewModel
    {
        public Deal Item { get; set; }

        public List<Deal> Deals { get; set; }

        public new MvxCommand GoToChildCommand
        {
            get => new MvxCommand(() => ShowViewModel<DetailsViewModel>(Item));
        }

        public ListViewModel()
        {
            Deals = LocalData.AllDeals();
            Name = "List";
            Icon = "deals";
        }
    }
}