using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LolProjectMobile2
{
    public class ItemsAdminVMList : ViewModel
    {
        public List<Items> Items { get; set; }
        public ICommand CreateItemCommand { protected set; get; }
        public ICommand DeleteItemCommand { protected set; get; }
        public ICommand SaveItemCommand { protected set; get; }
        public ICommand BackCommand { protected set; get; }

        
        public INavigation Navigation { get; set; }
        public ItemsAdminVMList()
        {
            Items = new List<Items>();
            SaveItemCommand = new Command(SaveItem);
            DeleteItemCommand = new Command(RemoveItem);
            BackCommand = new Command(Back);
            CreateItemCommand = new Command(CreateItem);
        }
        private Items selectedItems;
        public Items SelectedItems
        {
            get { return selectedItems; }
            set
            {
                //BooksViewModel book=value;
                selectedItems = value;
                ItemsAdminVM viewModel = new ItemsAdminVM(selectedItems) { ItemsAdminVMList = this };
                OnPropertyChanged("SelectedItems");
                Navigation.PushAsync(new ItemsAdminTablePageEdit(viewModel));
            }
        }
        private void CreateItem()
        {
            Navigation.PushAsync(new ItemsAdminTablePageEdit(new ItemsAdminVM() { ItemsAdminVMList = this }));
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveItem(object bookObj)
        {
            
            ItemsAdminVM book = bookObj as ItemsAdminVM;
            if (string.IsNullOrWhiteSpace(book.ItemName))
            {
                Application.Current.MainPage.DisplayAlert("Ошибка", "Вы не ввели что-то", "Ок");
                return;
            }
            else
            {
                var r = App.Database.SaveItemItems(new Items
                {
                    Id = book.Id,
                    ItemName = book.ItemName,
                    AD = book.AD,
                    AP = book.AP,
                    Crit = book.Crit,
                    Attack_speed = book.Attack_speed,
                    Movement = book.Movement,
                    Armor = book.Armor,
                    HP = book.HP,
                    ImageItem = book.ImageItem,
                    Modificators = book.Modificators
                });
                Back();
            }
        }
        private void RemoveItem(object bookObj)
        {
            try
            {
                App.Database.DeleteItem(selectedItems.Id);
                Back();
            }
            catch
            {
                Application.Current.MainPage.DisplayAlert("Ошибка", "Вы что-то изменили", "Ок");
            }
        }

    }
}
