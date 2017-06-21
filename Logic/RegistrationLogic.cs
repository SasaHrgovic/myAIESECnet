using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Logic
{
    public class RegistrationLogic
    {
        public bool Register(User u)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                Role r = db.Roles.Find(1);
                u.UsersRoles.Add(new UserRole() { Role = r, User = u });
                db.Users.Add(u);
                db.SaveChanges();
                return true;
            }
        }
    }
}
