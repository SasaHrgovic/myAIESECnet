﻿using Data;
using Logic.Properties;
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

        private static void SetToSession(User u)
        {
            Session.userId = u.Id;
            Session.committeeId = u.CommitteeId;
            Session.roleId = (u.UsersRoles.FirstOrDefault()).RoleId;
            Settings.Default.Email = u.Email;
            Settings.Default.Save();
        }


        public static bool LoginFromSession()
        {
            if (Settings.Default.Email != null)
            {
                using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
                {
                    User u = db.Users.FirstOrDefault(x => x.Email == Settings.Default.Email);
                    if (u != null)
                    {
                        SetToSession(u);
                        return true;
                    }

                    else return false;

                }

            }
            else return false;
        }

        public bool Login(string email, string password)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                User u = db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
                if (u != null)
                {
                    SetToSession(u);
                    return true;
                }               
                else return false;               
            }
              
        }

        public static void LogOut()
        {
            Settings.Default.Email = null;
            Settings.Default.Save();
        }

        public static bool GetSettings()
        {
            if (Settings.Default.Email == null)
            {
                return true;
            }
            else return false;
        }
    }
}
