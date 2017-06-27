using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class CommitteeLogic
    {
        public static List<Committee> Get()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Committee> committees = db.Committees.ToList();
                return committees;
            }
        }

        public static void Add(Committee newCommittee)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Committees.Add(newCommittee);
                db.SaveChanges();
            }
        }

        public static void Update(Committee committeeToUpdate, Committee newCommittee)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Committees.Attach(committeeToUpdate);
                committeeToUpdate.Name = newCommittee.Name;
                db.SaveChanges();
            }
        }

        public static void Delete(Committee committeeToUpdate)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Committees.Attach(committeeToUpdate);
                db.Committees.Remove(committeeToUpdate);
                db.SaveChanges();
            }
        }
    }
}
