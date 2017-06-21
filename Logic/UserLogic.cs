using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class UserLogic
    {
        public static List<User> GetCommitteMembers()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<User> members = db.Users.Where(x => x.CommitteeId == Session.committeeId).ToList();
                return members;
            }
        }
    }
}
