// File: ProfileViewModel.cs
// Author: Kingamattack
// Date: 19/7/2018

using RicardoDealCommunity.Models;
using RicardoDealCommunity.Services;

using System.Collections.Generic;

namespace RicardoDealCommunity.ViewModels
{
    public class ProfileViewModel : ChildViewModel
    {
        public string Username = "Kingamattack";

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

        private readonly DealService dealService;

        public ProfileViewModel()
        {
            Name = "Profile";
            Icon = "profile";

            dealService = new DealService();
            MyDeals = dealService.GetFavorites();
        }

        void SwitchList()
        {
            MyDeals.Clear();

            if(Index == 0)
                MyDeals = dealService.GetFavorites();
            else
                MyDeals = dealService.GetMyDeals();
        }
    }
}