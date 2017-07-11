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
        public List<Project> Get()
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Project> projects = db.Projects.ToList();
                return projects;
            }
        }

        public static List<Project> GetByTeamId(int teamId)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Project> projects = db.Teams.Where(y => y.Id == teamId).SelectMany(x => x.TeamsProjects.Select(z => z.Project)).ToList();
                return projects;
            }
        }

        public static void Add(Project newProject)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Projects.Add(newProject);
                db.SaveChanges();
            }
        }

        public static void Update(Project projectToUpdate, Project newProject)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Projects.Attach(projectToUpdate);
                projectToUpdate.Name = newProject.Name;
                projectToUpdate.Description = newProject.Description;
                db.SaveChanges();
            }
        }

        public static void Delete(Project projectToUpdate)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Projects.Attach(projectToUpdate);
                db.Projects.Remove(projectToUpdate);
                db.SaveChanges();
            }
        }
    }
}
