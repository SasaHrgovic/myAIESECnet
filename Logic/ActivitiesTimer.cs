using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public static class ActivitiesTimer
    {
        private static List<Activity> activities;

        public static void SetActivitiesList()
        {
            activities = ActivityLogic.Get();
        }

        public static Activity CheckDeadline()
        {
            DateTime currentTime = DateTime.Now;
            foreach(Activity activity in activities)
            {
                if (Math.Abs((currentTime - activity.Deadline.Value).TotalMinutes) < 1)
                {
                    return activity;
                }
            }
            return null;
        }
    }
}
