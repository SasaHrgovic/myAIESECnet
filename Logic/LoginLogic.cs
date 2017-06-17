using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LoginLogic
    {
        public List<int[]> GetDate()
        {
            
            int[] days31 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            int[] days30 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int[] days28 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28 };


            int[] months = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            int[] years = new int[50];
            int index = 0;

            for (int i = 1970; i < 2020; i++)
            {
                years[index] = i;
                index++;
            }

            List<int[]> listArray = new List<int[]>();
            listArray.Add(months);
            listArray.Add(days28);
            listArray.Add(days30);
            listArray.Add(days31);
            listArray.Add(years);

            return listArray;
        }

        public List<Committee> GetCommittees()
        {
            using(MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Committee> committees = db.Committees.ToList();
                return committees;
            }
            
        }

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

        private void SetToSession(User u)
        {
            Session.userId = u.Id;
            Session.committeeId = u.CommitteeId;
            Session.roleId = 2;
        }

        public bool Login(string email, string password)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                User u = db.Users.FirstOrDefault(x => x.Email == email);
                if (u != null)
                {
                    if (u.Password == password)
                    {
                        SetToSession(u);
                        return true;
                    }
                    else return false;
                }
               
                else return false;
                
            }
              
        }
    }
}
