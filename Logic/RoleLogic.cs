using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class RoleLogic
    {
        public static List<Role> Get()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Role> roles = db.Roles.ToList();
                return roles;
            }
        }
    }
}
