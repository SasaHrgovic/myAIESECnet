﻿using System;
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
        public List<Team> getTeams()
        {
            using(MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Team> teams = db.Teams.ToList();
                return teams;
                
            }
        }

        public void AddTeam(Team newTeam)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                newTeam.CommitteeId = 1;
                db.Teams.Add(newTeam);
                db.SaveChanges();
            }
        }

        public void UpdateTeam(Team teamToUpdate, Team newTeam)
        {
            using (MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                db.Teams.Attach(teamToUpdate);
                teamToUpdate.Name = newTeam.Name;
                teamToUpdate.Description = newTeam.Description;
                teamToUpdate.Start = newTeam.Start;
                teamToUpdate.End = newTeam.End;
                db.SaveChanges();
            }
        }

        public void DeleteTeam(Team teamToUpdate)
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
