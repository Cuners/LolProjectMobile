using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
namespace LolProjectMobile2
{
    public class AuthAndRegistVM : ViewModel
    {
        public List<Polzovatel> Polzovatels { get; set; }
        public AuthAndRegistVM()
        {
            Polzovatels = App.Database.GetItemsPolzovatel();
            RegistLoginCommand = new Command(SaveLogin);
            AuthLoginCommand = new Command(Auth);
            GoToRegist = new Command(GoToReg);
        }
        private string _login;
        public string Login 
        { 
            get { return _login; }
            set =>Set(ref _login, value);
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set=>Set(ref _password, value);
        }
        private DateTime _dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set=>Set(ref _dateOfBirth, value);
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set=>Set(ref _email, value);    
        }
        private string _mes;
        public string Mes
        {
            get { return _mes; }
            set=>Set(ref _mes, value);
        }
        public ICommand RegistLoginCommand { protected set; get; }
        public ICommand AuthLoginCommand { protected set; get; }
        public INavigation Navigation { get; set; }
        private void SaveLogin(object loginObj)
        {
            if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Email))
            {
                Application.Current.MainPage.DisplayAlert("Ошибка", "Вы не ввели что-то", "Ок");
                return;
            }
            else
            {
                var r = App.Database.SaveItemPolzovatel(new Polzovatel
                {
                    Login = Login,
                    Password = Password,
                    DateOfBirth = DateOfBirth,
                    Email = Email,
                    IdRole = 2
                });
                Polzovatels = App.Database.GetItemsPolzovatel();
                Navigation.PopAsync();
            }
        }
        public ICommand GoToRegist { protected set; get; }
        private void GoToReg(object loginObj)
        {
            Navigation.PushAsync(new RegistPage());
        }
        private void Auth(object loginObj)
        {
            if (string.IsNullOrWhiteSpace(Login) || string.IsNullOrWhiteSpace(Password))
            {
                Application.Current.MainPage.DisplayAlert("Ошибка", "Вы не ввели что-то", "Ок");
                return;
            }
            else
            {
                foreach (Polzovatel polzovatel in Polzovatels)
                {
                    if (polzovatel.Login == Login && polzovatel.Password == Password && polzovatel.IdRole == 2)
                    {
                        Application.Current.MainPage.DisplayAlert("Успешно", "Вы успешно зарегистрировались", "Ок");
                        Navigation.PopAsync();
                        LoginMod.LoginNow = Login;
                    }
                    else if(polzovatel.Login == Login && polzovatel.Password == Password && polzovatel.IdRole == 1)
                    {
                        Navigation.PushAsync(new AdminPage());
                        LoginMod.LoginNow = Login;
                    }
                }
            }
        }
    }
}
