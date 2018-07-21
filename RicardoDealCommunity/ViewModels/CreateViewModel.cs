// File: CreateViewModel.cs
// Author: Kingamattack
// Date: 20/7/2018

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

namespace RicardoDealCommunity.ViewModels
{
    public class CreateViewModel : ChildViewModel
    {
        public Deal CreatedDeal { get; set; }

        public string[] Deals { get; set; }

        public string City { get; set; }

        public MvxCommand SaveDealCommand 
        { 
            get => new MvxCommand(SaveDeal);
        }

        public MvxCommand ResetDealCommand
        {
            get => new MvxCommand(ResetDeal);
        }

        public CreateViewModel()
        {
            Name = "Create";
            Icon = "create";

            Deals = LocalData.Cities();
        }
                    
        void SaveDeal()
        {
            if (CreatedDeal == null)
                return;

            if (string.IsNullOrWhiteSpace(CreatedDeal.Name))
                return;

            if (CreatedDeal.Price <= 0.0)
                return;

            if (string.IsNullOrWhiteSpace(CreatedDeal.City))
                return;

            if (string.IsNullOrWhiteSpace(CreatedDeal.Description))
                return;
        }

        void ResetDeal()
        {
            CreatedDeal = new Deal();
        }
    }
}