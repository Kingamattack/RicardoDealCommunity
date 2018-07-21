// File: HomeViewModel.cs
// Author: Kingamattack
// Date: 20/7/2018

using System.Collections.Generic;
using MvvmCross.Core.ViewModels;

namespace RicardoDealCommunity.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        private List<ChildViewModel> _myViewModels;
        public List<ChildViewModel> MyViewModels
        {
            get { return _myViewModels; }
            set
            {
                _myViewModels = value;
                RaisePropertyChanged(() => MyViewModels);
            }
        }

        public HomeViewModel()
        {
            MyViewModels = new List<ChildViewModel>
            {
                new ListViewModel(),
                new CreateViewModel(),
                //new SearchViewModel(),
                new ProfileViewModel()
            };
        }
    }
}