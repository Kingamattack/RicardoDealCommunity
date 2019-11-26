// File: App.cs
// Author: Jordy Kingama
// Date: 26/11/2019

using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;

namespace RicardoDealCommunity.ViewModels
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<HomeViewModel>();
        }
    }
}