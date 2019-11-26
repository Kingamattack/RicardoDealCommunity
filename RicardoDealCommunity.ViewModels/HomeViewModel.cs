// File: HomeViewModel.cs
// Author: Kingamattack
// Date: 20/7/2018

using MvvmCross.Core.ViewModels;

using System.Collections.Generic;

namespace RicardoDealCommunity.ViewModels
{
    public class HomeViewModel : MvxViewModel
    {
        List<ChildViewModel> _myViewModels;
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
                new ProfileViewModel()
            };
        }
    }
}