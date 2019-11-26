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

        public MvxCommand SaveDealCommand => new MvxCommand(SaveDeal);

        public MvxCommand ResetDealCommand => new MvxCommand(ResetDeal);

        private DealService dealService;

        public CreateViewModel()
        {
            Name = "Create";
            Icon = "create";

            dealService = new DealService();

            CreatedDeal = new Deal();
            Deals = dealService.Cities();
        }
                    
        void SaveDeal()
        {
            if (CreatedDeal == null)
                return;

            if (string.IsNullOrWhiteSpace(CreatedDeal.Name))
                return;

            if (CreatedDeal.Price < 0.0)
                return;

            if (string.IsNullOrWhiteSpace(CreatedDeal.Description))
                return;

            if (string.IsNullOrWhiteSpace(CreatedDeal.City))
                return;

            dealService.AddDeal(CreatedDeal);
            ShowViewModel<ListViewModel>();
        }

        void ResetDeal()
        {
            CreatedDeal.Name = string.Empty;
            CreatedDeal.Price = 0;
            CreatedDeal.Description = string.Empty;
            CreatedDeal.City = string.Empty;
        }
    }
}