using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LolProjectMobile2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemsAdminTablePage : ContentPage
    {
        public ItemsAdminTablePage()
        {
            InitializeComponent();
            BindingContext = new ItemsAdminVMList() { Navigation=this.Navigation};
        }
        protected override void OnAppearing()
        {
            itemsListView.ItemsSource = App.Database.GetItemsItems();
            base.OnAppearing();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            itemsListView.ItemsSource=App.Database.SearchItem(e.NewTextValue);
        }
    }
}