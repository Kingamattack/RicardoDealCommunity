// File: CreateView.cs
// Author: Kingamattack
// Date: 20/7/2018

using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;

using RicardoDealCommunity.ViewModels;

namespace RicardoDealCommunity.iOS.Views.Tabs.Create
{
    public partial class CreateView : MvxViewController<CreateViewModel>
    {
        public CreateView() : base(nameof(CreateView), null) {}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<CreateView, CreateViewModel>();
            set.Bind(NameTextField).To(vm => vm.CreatedDeal.Name);
            set.Bind(PriceTextField).To(vm => vm.CreatedDeal.Price);
            set.Bind(CityTextField).To(vm => vm.CreatedDeal.City);
            set.Bind(DescriptionTextField).To(vm => vm.CreatedDeal.Description);

            set.Bind(SaveButton).To(vm => vm.SaveDealCommand);
            set.Bind(ClearButton).To(vm => vm.ResetDealCommand);

            set.Apply();
        }
    }
}