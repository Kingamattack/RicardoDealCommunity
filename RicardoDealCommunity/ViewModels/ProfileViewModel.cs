// File: ProfileViewModel.cs
// Author: Kingamattack
// Date: 19/7/2018

using System.Collections.Generic;

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

namespace RicardoDealCommunity.ViewModels
{
    public class ProfileViewModel : ChildViewModel
    {
        public string Username { get; set; } = "Kingamattack";

        public List<Deal> MyDeals { get; set; }

        public ProfileViewModel()
        {
            Name = "Profile";
            Icon = "profile";

            MyDeals = LocalData.GetMyDeals();
        }
    }
}