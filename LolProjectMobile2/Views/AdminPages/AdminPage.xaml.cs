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
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void AppealBut_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AppealsAdminPages());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsSelectAdminPage());
        }
    }
}