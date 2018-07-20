// File: ChildViewModel.cs
// Author: Kingamattack
// Date: 20/7/2018

using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace RicardoDealCommunity.ViewModels
{
    public class ChildViewModel : MvxViewModel
    {
        public ChildViewModel(string name = "default", string icon = "deals")
        {
            Name = name;
            Icon = icon;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }

        private string _icon;
        public string Icon
        {
            get { return _icon; }
            set
            {
                _icon = value;
                RaisePropertyChanged(() => Icon);
            }
        }

        public ICommand GoToChildCommand => new MvxCommand(() => ShowViewModel<MvxViewModel>());
    }
}