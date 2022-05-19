using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class UserContext : DbContext
    {
        public UserContext() : base(Properties.Settings.Default.DbConnect)
        { }

        public bool TestUsersIfEmpty()
        {
            UserContext context = new UserContext();
            IEnumerable<User> queryUsers = context.Users;
            return queryUsers.Count() == 0;
        }

        public DbSet<User> Users { get; set; }

        public void CopyTestUsers()
        {
            UserContext context = new UserContext();

            foreach (User user in UserData.TestUsers)
            {
                context.Users.Add(user);
            }

            context.SaveChanges();
        }
    }
}
