using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ActivityLogic
    {
        private static List<User> _currentMembers = null;
        private static List<User> _usersToAdd = new List<User>();
        private static List<User> _usersToDelete = new List<User>();
        public static List<Activity> Get()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Activity> activities = db.Activities.ToList();
                return activities;
            }
        }

        public static List<User> GetActivityMembers(Activity a)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Activities.Attach(a);
                List<User> users = a.Users.ToList();
                return users;
            }
        }

        private static Activity DeleteActivityMembers(Activity activity)
        {
            foreach (User activityMember in _usersToDelete)
            {
                activity.Users.Remove(activityMember);
            }
            return activity;
        }

        private static Activity AddActivityMembers(Activity activity)
        {
            foreach (User activityMember in _usersToAdd)
            {
                activity.Users.Add(activityMember);
            }
            return activity;
        }

        public static void Add(Activity newActivity, List<User> usersToActivity)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                if (usersToActivity != null)
                {
                    _usersToAdd = usersToActivity;
                    newActivity = AddActivityMembers(newActivity);
                }
                db.Activities.Attach(newActivity);
                db.Activities.Add(newActivity);
                db.SaveChanges();
            }
        }

        public static void Update(Activity activityToUpdate, Activity newActivity, List<User> usersToActivity)
        {
            _currentMembers = GetActivityMembers(activityToUpdate);
            //_currentMembers = activityToUpdate.Users.ToList();
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Activities.Attach(activityToUpdate);
                
                activityToUpdate.Name = newActivity.Name;
                activityToUpdate.Description = newActivity.Description;
                if (usersToActivity != null)
                {
                    _usersToDelete = _currentMembers.Except(usersToActivity, new UserListEqualityComparer()).ToList();
                    if (_usersToDelete.Count != 0)
                    {
                        foreach (User activityMember in _usersToDelete)
                        {
                            activityToUpdate.Users.Remove(activityMember);
                        }
                    }

                    _usersToAdd = usersToActivity.Except(_currentMembers, new UserListEqualityComparer()).ToList();
                    if (_usersToAdd.Count != 0)
                    {
                        foreach (User activityMember in _usersToAdd)
                        {
                            activityToUpdate.Users.Add(activityMember);
                        }
                    }
                        //activityToUpdate = AddActivityMembers(activityToUpdate);
                }
                
                db.SaveChanges();
            }
        }

        public static void Delete(Project activityToUpdate)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Projects.Attach(activityToUpdate);
                db.Projects.Remove(activityToUpdate);
                db.SaveChanges();
            }
        }
    }
}
