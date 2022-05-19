using System;
using System.Collections.Generic;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            UserRoles currentUserRole = LoginValidator.Authenticate(username, password, new LoginValidator.ActionOnError(LogErrorToConsole));

            switch (currentUserRole)
            {
                case UserRoles.ADMIN:
                    Admin();
                    break;
                case UserRoles.ANONYMOUS:
                    Console.WriteLine("Anonymous user!");
                    break;
                default:
                    break;
            }


        }
        static public void Admin()
        {
            while (true)
            {
                Console.Write("\nChoose what to do:\n0: Exit\n1: Change user role\n2: Change user account expiration date\n3: List all users\n4: Show logs\n5: Show current session logs\n6: Create certificate for a student\nYour choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Role: ");
                        UserRoles role = (UserRoles)Enum.Parse(typeof(UserRoles), Console.ReadLine().ToUpper());
                        UserData.AssignUserRole(username, role);
                        break;
                    case 2:
                        Console.Write("Username: ");
                        username = Console.ReadLine();
                        Console.Write("Date: ");
                        DateTime date = DateTime.Parse(Console.ReadLine());
                        UserData.SetUserExpirationDate(username, date);
                        break;
                    case 3:
                        UserData.ListUsers();
                        return;
                    case 4:
                        foreach (string log in Logger.GetLogs())
                        {
                            Console.WriteLine(log);
                        }
                        return;
                    case 5:
                        foreach (string activity in Logger.GetCurrentSessionActivities(""))
                        {
                            Console.WriteLine(activity);
                        }
                        return;
                    case 6:
                        Console.Write("Student name: ");
                        username = Console.ReadLine();
                        Console.Write("Path to save the certificate: ");
                        string pathToFile = Console.ReadLine();
                        UserData.PrepareCertificate(username, pathToFile);
                        break;
                    default:
                        Console.WriteLine("Wrong option!");
                        break;
                }
            }
        }
        static public void LogErrorToConsole(string errorMsg)
        {
            Console.WriteLine("Error occurred: " + errorMsg);
        }

    }
}