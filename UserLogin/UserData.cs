using System;
using System.Collections.Generic;
using System.Linq;


namespace UserLogin
{
    public static class UserData
    {
        public static List<User> TestUsers
        {
            get { return _testUsers; }
        }
        private static List<User> _testUsers= new List<User>{ new User("Pavel", "admin", "121219044", UserRoles.INSPECTOR.ToString(), DateTime.Now) ,
                                                               new Student("Denislav","Biserov", "Petkov", "FKST", "KSI","Bachelor","Learning","121219000",6,9,29),
                                                                new Student("Ivan", "Hristov", "Ivanov", "FKST", "KSI", "Bachelor", "Learning", "121219099", 6, 9, 29)};


        static public User IsUserPassCorrect(string username, string password)
        {
            return (from user in new UserContext().Users
                    where user.Username.Equals(username) && user.Password.Equals(password)
                    select user).First();
        }

        static public void SetUserExpirationDate(string username, DateTime newExpirationDate)
        {
            UserContext context = new UserContext();

            foreach (User user in context.Users)
            {
                if (user.Username.Equals(username))
                {
                    Logger.LogActivity("Changed account expiration date of user " + user.Username);
                    user.ExpirationDate = newExpirationDate;
                    context.SaveChanges();
                    return;
                }
            }
            Logger.LogActivity("User " + username + " not found!");
        }

        static public void AssignUserRole(string username, UserRoles newUserRole)
        {
            UserContext context = new UserContext();

            foreach (User user in context.Users)
            {
                if (user.Username.Equals(username))
                {
                    Logger.LogActivity("Changed role of user " + user.Username);
                    user.Role = newUserRole.ToString();
                    context.SaveChanges();
                    return;
                }
            }
            Logger.LogActivity("User " + username + " not found!");
        }

        static public void ListUsers()
        {
            Logger.LogActivity("Listed users");
            foreach (User user in new UserContext().Users)
            {
                Console.WriteLine(user);
            }
        }

        static public void PrepareCertificate(string username, string pathToFile)
        {
            Student student = GetStudent(username);
            if (student == null)
            {
                Logger.LogActivity("Student " + username + " not found!");
                return;
            }
            Logger.LogActivity("Creating a certificate for student " + username);
            Logger.CreateCertificate("Certificate for a completed semester for student " + student.Username + student.ToString(), pathToFile);
            return;
        }



        static private Student GetStudent(string username)
        {
            foreach (User user in _testUsers)
            {
                if (user.Username.Equals(username) && user.Role == UserRoles.STUDENT.ToString())
                {
                    return (Student)user;
                }
            }

            return null;

        }
    }

}