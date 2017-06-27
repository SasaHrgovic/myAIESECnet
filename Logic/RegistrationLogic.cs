using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Text.RegularExpressions;

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

        public bool CheckEmail(string email)
        {
            Regex r = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
            Match m = r.Match(email);
            if (m.Success) return true;
            else return false;
        }
    }
}
