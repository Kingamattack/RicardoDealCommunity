// File: ProfileViewModel.cs
// Author: Kingamattack
// Date: 19/7/2018
using System;
using MvvmCross.Core.ViewModels;

namespace RicardoDealCommunity.ViewModels
{
    public class ProfileViewModel : ChildViewModel
    {
        public ProfileViewModel()
        {
            Name = "Profile";
            Icon = "profile";
        }
    }
}
