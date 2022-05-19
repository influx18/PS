using System;

namespace UserLogin
{
    public class User
    {
        public int UserId { get; set; }

        public User() { }

        public User(string userName, string password, string facNumber, string role, DateTime creationData)
        {
            Username = userName;
            Password = password;
            FacNumber = facNumber;
            Role = role;
            CreationDate = creationData;
            ExpirationDate = new DateTime(2999, 1, 1);
        }

        public DateTime? ExpirationDate
        { get; set; }
        public DateTime? CreationDate
        { get; set; }
        public string Username
        { get; set; }
        public string Password
        { get; set; }
        public string FacNumber
        { get; set; }
        public string Role
        { get; set; }

        public override string ToString()
        {
            return "\nUsername: " + Username +
                    "\nFaculty number: " + FacNumber +
                    "\nRole: " + Role;
        }

    }
}