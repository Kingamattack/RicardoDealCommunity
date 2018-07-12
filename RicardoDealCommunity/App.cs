// File: AssemblyInfo.cs
// Author: Kingamattack
// Date: 12/7/2018

using MvvmCross.Platform.IoC;

namespace RicardoDealCommunity
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.DealsViewModel>();
        }
    }
}