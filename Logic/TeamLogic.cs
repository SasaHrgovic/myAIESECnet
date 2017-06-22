using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.ComponentModel;
using System.Data.Entity;

namespace Logic
{
    public class TeamLogic
    {
        private List<User> _currentMembers = null;
        private List<User> _usersToAdd = new List<User>();
        private List<User> _usersToDelete = new List<User>();
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

        private Team DeleteTeamMembers(Team team)
        {
            foreach (User teamMember in _usersToDelete)
            {
                UserTeam ut = team.UsersTeams.Where(y => y.UserId == teamMember.Id).Single();
                team.UsersTeams.Remove(ut);
            }
            return team;
        }

        private Team AddTeamMembers(Team team)
        {
            foreach (User teamMember in _usersToAdd)
            {
                team.UsersTeams.Add(new UserTeam() { TeamId = team.Id, UserId = teamMember.Id });
            }
            return team;
        }

        public void Add(Team newTeam, List<User> teamMembers)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                if (teamMembers != null)
                {
                    _usersToAdd = teamMembers;
                    newTeam = AddTeamMembers(newTeam);
                }
                newTeam.CommitteeId = Session.committeeId;
                db.Teams.Add(newTeam);
                db.SaveChanges();
            }
        }

        public void Update(Team teamToUpdate, Team newTeam, List<User> teamMembers)
        {
            _currentMembers = GetTeamMembers(teamToUpdate);
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Teams.Attach(teamToUpdate);
                teamToUpdate.Name = newTeam.Name;
                teamToUpdate.Description = newTeam.Description;
                teamToUpdate.Start = newTeam.Start;
                teamToUpdate.End = newTeam.End;
                teamToUpdate.Type = newTeam.Type;

                if (teamMembers != null)
                {
                    _usersToDelete = _currentMembers.Except(teamMembers, new UserListEqualityComparer()).ToList();
                    if (_usersToDelete != null)
                        teamToUpdate = DeleteTeamMembers(teamToUpdate);

                    _usersToAdd = teamMembers.Except(_currentMembers, new UserListEqualityComparer()).ToList();
                    if (_usersToAdd != null)
                        teamToUpdate = AddTeamMembers(teamToUpdate);
                }

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
