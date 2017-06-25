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
        public static List<Activity> Get()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Activity> activities = db.Activities.ToList();
                return activities;
            }
        }

        public static void Add(Activity newActivity)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Activities.Add(newActivity);
                db.SaveChanges();
            }
        }

        public static void Update(Activity activityToUpdate, Project newActivity)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Activities.Attach(activityToUpdate);
                activityToUpdate.Name = newActivity.Name;
                activityToUpdate.Description = newActivity.Description;
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
