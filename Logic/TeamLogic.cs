using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.ComponentModel;

namespace Logic
{
    public class TeamLogic
    {
        public List<Team> Get()
        {
            using(MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Team> teams = db.Teams.ToList();
                return teams;
                
            }
        }

        public List<User> GetTeamMembers(Team t)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Teams.Attach(t);
                List<User> users = t.UsersTeams.Select(y => y.User).ToList();
                return users;

            }
        }

        private Team AddTeamMembers(Team newTeam, List<User> teamMembers)
        {
            foreach (User teamMember in teamMembers)
            {
                newTeam.UsersTeams.Add(new UserTeam() { TeamId = newTeam.Id, UserId = teamMember.Id });
            }
            return newTeam;
        }

        public void Add(Team newTeam, List<User> teamMembers)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                if (teamMembers != null) newTeam = AddTeamMembers(newTeam, teamMembers);
                newTeam.CommitteeId = Session.committeeId;
                db.Teams.Add(newTeam);
                db.SaveChanges();
            }
        }

        public void Update(Team teamToUpdate, Team newTeam, List<User> teamMembers)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                if (teamMembers != null) teamToUpdate = AddTeamMembers(newTeam, teamMembers);
                db.Teams.Attach(teamToUpdate);
                teamToUpdate.Name = newTeam.Name;
                teamToUpdate.Description = newTeam.Description;
                teamToUpdate.Start = newTeam.Start;
                teamToUpdate.End = newTeam.End;
                teamToUpdate.Type = newTeam.Type;
                db.SaveChanges();
            }
        }

        public void Delete(Team teamToUpdate)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Teams.Attach(teamToUpdate);
                db.Teams.Remove(teamToUpdate);
                db.SaveChanges();
            }
        }
    }
}
