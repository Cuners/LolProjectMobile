using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LolProjectMobile2
{
    public class AppealAdminVMList :ViewModel
    {
        private List<Appeals> _appeals;
        public List<Appeals> Appeals 
        { 
            get { return _appeals; }
            set =>Set(ref _appeals, value); 
        }
        public List<Appeals> AppealsBase { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand BackCommand { get; set; }
        public ICommand SaveAppealCommandAdmin { get; set; }
        public AppealAdminVMList()
        {
            AppealsBase = App.Database.GetItemsAppeal();
            Appeals= new List<Appeals>();
            foreach(Appeals appeal in AppealsBase)
            {
                if (appeal.Status == "Ожидает")
                {
                    Appeals.Add(appeal);
                }
            }
            BackCommand = new Command(Back);
            SaveAppealCommandAdmin=new Command(SaveAppeal);
        }
        private void Back()
        {
            Navigation.PopAsync();
        }
        private void SaveAppeal(object bookObj)
        {
            
            AppealAdminVM book = bookObj as AppealAdminVM;
            if (string.IsNullOrWhiteSpace(book.Otvet) || string.IsNullOrWhiteSpace(book.Tema) || string.IsNullOrWhiteSpace(book.Opisanie))
            {
                Application.Current.MainPage.DisplayAlert("Ошибка", "Вы не ввели что-то", "Ок");
                return;
            }
            else
            {
                var r = App.Database.SaveItemAppeal(new Appeals
                {
                    Id = book.Id,
                    Tema = book.Tema,
                    Opisanie = book.Opisanie,
                    Status = "Отвечено",
                    User_login = book.UserLogin,
                    Otvet = book.Otvet,
                    AdminLogin = book.Admin_Login
                });
                RemoveAppeal(book.Id);
                Back();
                
            }
        }
        public void RemoveAppeal(int appeal)
        {
            Appeals item = null;
            foreach (Appeals appeals in Appeals)
            {
                if (appeals.Id == appeal)
                {
                    item = appeals;
                    break;
                }
            }
            if (item != null)
            {
                Appeals.Remove(item);
            }
        }
        private Appeals selectedAppeal;
        public Appeals SelectedAppeal
        {
            get { return selectedAppeal; }
            set
            {
                //BooksViewModel book=value;
                selectedAppeal = value;
                AppealAdminVM viewModel = new AppealAdminVM(selectedAppeal) { AppealAdminVMList = this };
                OnPropertyChanged("SelectedAppeal");
                Navigation.PushAsync(new AppealsAdminEditPage(viewModel));
            }
        }
    }
}
