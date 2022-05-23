using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    public class LoginVM : ObservableObject
    {

        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                RaisePropertyChangedEvent("Username");
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