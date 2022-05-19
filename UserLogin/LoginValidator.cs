using System;

namespace UserLogin
{
    public class LoginValidator
    {

        public delegate void ActionOnError(string errorMsg);

        public static User currentUser
        { get; private set; }

        static public UserRoles Authenticate(string username, string password, ActionOnError actionOnError)
        {
            if (String.IsNullOrEmpty(username))
            {
                actionOnError("Empty username!");
                return UserRoles.ANONYMOUS;
            }
            else if (String.IsNullOrEmpty(password))
            {
                actionOnError("Empry password!");
                return UserRoles.ANONYMOUS;
            }
            if (username.Length < 5 || password.Length < 5)
            {
                actionOnError("Username or password under 5 symbols!");
                return UserRoles.ANONYMOUS;
            }

            currentUser = UserData.IsUserPassCorrect(username, password);
            if (currentUser == null)
            {
                actionOnError("User not found!");
                return UserRoles.ANONYMOUS;
            }
            Console.WriteLine("\nAuthenticated as a user " + currentUser);
            Logger.LogActivity("Logged successfully!");
            return (UserRoles)Enum.Parse(typeof(UserRoles), currentUser.Role, true);
        }
    }
}