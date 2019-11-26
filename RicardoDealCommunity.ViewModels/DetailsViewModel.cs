// File: DetailsViewModel.cs
// Author: Kingamattack
// Date: 13/7/2018

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

using System.Threading.Tasks;

namespace RicardoDealCommunity.ViewModels
{
    public class DetailsViewModel : MvxViewModel<Deal>
    {
        public Deal SelectedDeal { get; set; }

        private DealService dealService;

        public override void Prepare()
        {
            // first callback. Initialize parameter-agnostic stuff here
            dealService = new DealService();
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public void Init(Deal parameters)
        {
            SelectedDeal = parameters;
            SelectedDeal = dealService.GetDeal();
        }

        public override void Prepare(Deal parameter)
        {
            SelectedDeal = parameter;
        }
    }
}