// File: DetailsViewModel.cs
// Author: Kingamattack
// Date: 13/7/2018

using System;

using MvvmCross.Core.ViewModels;

using RicardoDealCommunity.Models;

namespace RicardoDealCommunity.ViewModels
{
    public class DetailsViewModel : MvxViewModel
    {
        public Deal CurrentDeal { get; set; }
    }
}