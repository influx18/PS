using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudentInfoSystem.ViewModel
{
    public class LoginCommand : ICommand
    {
        private LoginVM _loginVm;

        public LoginCommand(LoginVM loginVm)
        {
            _loginVm = loginVm;
        }

        public void Execute(object parameter)
        {
            PasswordBox pswd = (PasswordBox)parameter;

            UserLogin.UserRoles userRole = UserLogin.LoginValidator.Authenticate(_loginVm.Username, pswd.Password, null);

            if (userRole == UserLogin.UserRoles.STUDENT)
            {
                UserLogin.Student student = StudentValidation.GetStudentDataByUser(UserLogin.LoginValidator.currentUser);
                new MainWindow(student).Show();
            }
            if (userRole == UserLogin.UserRoles.INSPECTOR)
            {
                new StudentListWindow(UserLogin.StudentData.TestStudents).Show();
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

#pragma warning disable 67
        public event EventHandler CanExecuteChanged { add { } remove { } }
#pragma warning restore 67
    }
}