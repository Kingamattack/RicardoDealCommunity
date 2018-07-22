// File: DetailsViewModel.cs
// Author: Kingamattack
// Date: 13/7/2018

using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

namespace RicardoDealCommunity.ViewModels
{
    public class DetailsViewModel : MvxViewModel<Deal>
    {
        public Deal SelectedDeal { get; set; }

        public override void Prepare()
        {
            // first callback. Initialize parameter-agnostic stuff here
        }

        public override async Task Initialize()
        {
            await base.Initialize();
        }

        public void Init(Deal parameters)
        {
            SelectedDeal = parameters;
            SelectedDeal = LocalData.GetDeal();
        }

        public override void Prepare(Deal parameter)
        {
            SelectedDeal = parameter;
        }
    }
}