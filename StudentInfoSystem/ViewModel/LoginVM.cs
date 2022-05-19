using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    public class LoginVM : ObservableObject
    {
        
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChangedEvent("Username");
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChangedEvent("Password");
            }
        }


        public ICommand Login
        {
            get { return new LoginCommand(this); }
        }

        public ICommand NoLogin
        {
            get { return new NoLoginCommand(); }
        }


    }

}
