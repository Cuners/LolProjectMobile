using System;
using System.Collections.Generic;
using System.Text;

namespace LolProjectMobile2
{
    public class AppealAdminVM : ViewModel
    {
        public AppealAdminVM(Appeals appeals)
        {
            _tema = appeals.Tema;
            _opisanie = appeals.Opisanie;
            _status = appeals.Status;
            _user_login = appeals.User_login;
            _otvet = appeals.Otvet;
            Id=appeals.Id;
        }
        private AppealAdminVMList appealAdminVMList;
        public AppealAdminVMList AppealAdminVMList
        {
            get { return appealAdminVMList; }
            set=>Set(ref appealAdminVMList, value);
        }
        private string _tema;
        public string Tema
        {
            get { return _tema;}
            set=>Set(ref _tema, value);
        }
        private string _opisanie;
        public string Opisanie
        {
            get { return _opisanie;}
            set=>Set(ref _opisanie, value);
        }
        private string _status;
        public string Status
        {
            get { return _status;}
            set=>Set(ref _status, value);
        }
        private string _user_login;
        public string UserLogin
        {
            get => _user_login;
            set=> Set(ref _user_login, value);
        }
        private string _otvet;
        public string Otvet
        {
            get => _otvet;
            set=>Set(ref _otvet, value);
        }
        public int Id { get; set; }
        private string _admin_login = LoginMod.LoginNow;
        public string Admin_Login
        {
            get => _admin_login;
            set=> Set(ref _admin_login, value);
        }

    }
}
