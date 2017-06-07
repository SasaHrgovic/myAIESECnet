using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ProjectLogic
    {
        public List<Project> getProjects()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Project> projects = db.Projects.ToList();
                return projects;
            }
        }
    }
}
