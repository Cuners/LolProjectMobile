using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LolProjectMobile2
{
    public class ItemsAdminVM :ViewModel
    {
        public int Id { get; set; }
        private string _itemName;
        public string ItemName
        {
            get { return _itemName; }
            set => Set(ref _itemName, value);
        }
        private byte[] _imageItems;
        public byte[] ImageItem
        {
            get { return _imageItems; }
            set => Set(ref _imageItems, value);
        }
        private Nullable<int> _ad;
        public Nullable<int> AD
        {
            get { return _ad; }
            set => Set(ref _ad, value);
        }
        private Nullable<int> _crit;
        public Nullable<int> Crit
        {
            get { return _crit; }
            set => Set(ref _crit, value);
        }
        private Nullable<int> _ap;
        public Nullable<int> AP
        {
            get { return _ap; }
            set => Set(ref _ap, value);
        }
        private Nullable<int> _attack_speed;
        public Nullable<int> Attack_speed
        {
            get { return _attack_speed; }
            set => Set(ref _attack_speed, value);
        }
        private Nullable<int> _movement;
        public Nullable<int> Movement
        {
            get { return _movement; }
            set => Set(ref _movement, value);
        }
        private Nullable<int> _armor;
        public Nullable<int> Armor
        {
            get { return _armor; }
            set => Set(ref _armor, value);
        }
        private Nullable<int> _hp;
        public Nullable<int> HP
        {
            get { return _hp; }
            set => Set(ref _hp, value);
        }
        private string _modificators;
        public string Modificators
        {
            get { return _modificators; }
            set => Set(ref _modificators, value);
        }
        private ItemsAdminVMList itemsAdminVMList;
        public ItemsAdminVMList ItemsAdminVMList
        {
            get { return itemsAdminVMList; }
            set=>Set(ref itemsAdminVMList, value);
        }
        public ICommand TakePhoto { get; set; }
        public ItemsAdminVM()
        {
            TakePhoto = new Command(TookPhoto);
        }
        public ItemsAdminVM(Items items)
        {
            Id=items.Id;
            ItemName=items.ItemName;
            ImageItem = items.ImageItem;
            AD = items.AD;
            Crit = items.Crit;
            AP = items.AP;
            Attack_speed=items.Attack_speed;
            Movement = items.Movement;
            Armor = items.Armor;
            HP = items.HP;
            Modificators = items.Modificators;
            TakePhoto = new Command(TookPhoto);
        }
        async public void TookPhoto()
        {
            try
            {
                var photo = await MediaPicker.PickPhotoAsync();
               
                ImageItem = File.ReadAllBytes(photo.FullPath);
            }
            catch (Exception ex)
            {
                await App.Current.MainPage.DisplayAlert("Сообщение об ошибке", ex.Message, "ОК");
            }
        } 
    }
}
