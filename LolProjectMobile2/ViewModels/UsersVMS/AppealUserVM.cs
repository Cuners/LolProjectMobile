using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
namespace LolProjectMobile2
{
    public class AppealUserVM : ViewModel
    {
        public INavigation Navigation { get; set; }
        public ICommand SaveAppealCom { protected set; get; }
        public List<Appeals> AppealsBase { get; set; }
        public List<Appeals> Appeals { get; set; }
        public string UserLogin { get; set; } = LoginMod.LoginNow;
        public string Tema { get; set; }
        public string Opisanie { get; set; }
        private void SaveAppeal(object obj)
        {
            if(string.IsNullOrWhiteSpace(UserLogin) || string.IsNullOrWhiteSpace(Tema) || string.IsNullOrWhiteSpace(Opisanie))
            {
                Application.Current.MainPage.DisplayAlert("Ошибка", "Вы не ввели что-то", "Ок");
                return;
            }
            else
            {
               
                var r = App.Database.SaveItemAppeal(new Appeals
                {
                    Id=0,
                    Opisanie=Opisanie,
                    Status="Ожидает",
                    Tema=Tema,
                    User_login=UserLogin,
                    AdminLogin=null
                });
                Application.Current.MainPage.DisplayAlert("Успешно", "Вы написали жалобу", "Ок");
            }
        }

        public AppealUserVM()
        {
            Appeals = new List<Appeals>();
            AppealsBase = App.Database.GetItemsAppeal();
            foreach(Appeals appeal in AppealsBase)
            {
                if (appeal.Status == "Отвечено" && appeal.User_login==LoginMod.LoginNow && appeal.AdminLogin!=null)
                {
                    Appeals.Add(appeal);
                }
            }
            SaveAppealCom=new Command(SaveAppeal);
        }
    }
}
