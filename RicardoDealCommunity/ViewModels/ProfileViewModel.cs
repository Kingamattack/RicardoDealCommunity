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
        public string Username { get; set; } = LocalData.username;

        List<Deal> myDeals = new List<Deal>();
        public List<Deal> MyDeals
        {
            get => myDeals; 
            set
            {
                myDeals = value; 
                RaisePropertyChanged(() => MyDeals);
            }
        }

        int index;
        public int Index
        {
            get { return index; }
            set
            {
                index = value;
                RaisePropertyChanged(() => Index);
                SwitchList();
            }
        }

        public ProfileViewModel()
        {
            Name = "Profile";
            Icon = "profile";

            MyDeals = LocalData.GetFavorites();
        }

        void SwitchList()
        {
            MyDeals.Clear();

            if(Index == 0)
                MyDeals = LocalData.GetFavorites();
            else
                MyDeals = LocalData.GetMyDeals();
        }
    }
}