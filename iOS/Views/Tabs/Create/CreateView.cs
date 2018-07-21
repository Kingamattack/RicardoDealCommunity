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
            set.Bind(CitiesPickerView).For(p => p.DataSource).To(vm => vm.Deals);
            set.Bind(DescriptionTextField).To(vm => vm.CreatedDeal.Description);

            /*this.AddBindings(new Dictionary<object, string>
            {
                { source, "ItemsSource Deals" }
            });*/

            set.Bind(SaveButton).To(vm => vm.SaveDealCommand);
            set.Bind(ClearButton).To(vm => vm.ResetDealCommand);

            set.Apply();
        }
    }
}