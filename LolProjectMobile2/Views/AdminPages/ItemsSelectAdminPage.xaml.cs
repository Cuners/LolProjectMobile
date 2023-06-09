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
    public partial class ItemsSelectAdminPage : ContentPage
    {
        public ItemsSelectAdminPage()
        {
            InitializeComponent();
        }

        private void ItemsDifferents_Clicked(object sender, EventArgs e)
        {

        }

        private void Items_Difference_Clicked(object sender, EventArgs e)
        {

        }

        private void ItemButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsAdminTablePage());
        }
    }
}