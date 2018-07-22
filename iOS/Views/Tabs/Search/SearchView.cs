// File: SearchView.cs
// Author: Kingamattack
// Date: 22/7/2018

using MvvmCross.iOS.Views;

using RicardoDealCommunity.ViewModels;

namespace RicardoDealCommunity.iOS.Views.Tabs.Search
{
    public partial class SearchView : MvxViewController<SearchViewModel>
    {
        public SearchView() : base(nameof(SearchView), null) {}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


        }
    }
}