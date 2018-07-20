// File: DetailsViewModel.cs
// Author: Kingamattack
// Date: 13/7/2018

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.ViewModels
{
    public class DetailsViewModel : MvxViewModel<Deal>
    {
        public Deal SelectedDeal { get; set; }

        public override void Prepare(Deal parameter)
        {
            SelectedDeal = parameter;
        }
    }
}