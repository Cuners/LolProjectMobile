using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
namespace LolProjectMobile2
{
    public class MainListVM : ViewModel
    {

        public List<Heroes> Heroes { get; set; }
        public List<Items> Items { get; set; }
        
       
        public INavigation Navigation { get; set; }
        public MainListVM()
        {
            // Heroes = new ObservableCollection<Heroes>();
            // Appeals = new ObservableCollection<Appeals>();
            Heroes=new List<Heroes>();
            Heroes = App.Database.GetItemsHeroes();
            Items = App.Database.GetItemsItems();
           
        }
        private Heroes selectedHero;
        public Heroes SelectedHero
        {
            get { return selectedHero; }
            set
            {
                selectedHero = value;
                HeroesVM vm = new HeroesVM(selectedHero) { MainListVM = this };
                OnPropertyChanged("SelectedHero");
                Navigation.PushAsync(new HeroesSelectPage(vm));
             
            }
        }
    }
}
