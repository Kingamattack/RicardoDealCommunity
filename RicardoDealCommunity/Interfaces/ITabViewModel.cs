// File: ITabViewModel.cs
// Author: Kingamattack
// Date: 20/7/2018
using System;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;

namespace RicardoDealCommunity.Interfaces
{
    public interface ITabViewModel
    {
        string Name { get; set; }
        string Icon { get; set; }

        ICommand GoToChildCommand { get; set; }// => new MvxCommand(() => ShowViewModel<MvxViewModel>());
    }
}
