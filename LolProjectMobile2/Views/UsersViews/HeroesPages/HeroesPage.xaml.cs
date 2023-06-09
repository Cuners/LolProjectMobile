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
    public partial class HeroesPage : ContentPage
    {
        public HeroesPage()
        {
            InitializeComponent();
            BindingContext=new MainListVM() { Navigation = this.Navigation };
        }
      /*  protected override void OnAppearing()
        {
            HeroesList.ItemsSource = App.Database.GetItemsHeroes();
            base.OnAppearing();
        } */
    }
}