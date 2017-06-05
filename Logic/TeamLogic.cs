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
        public List<Team> getTeams()
        {
            using(MyAiesecNetDbContext db = new MyAiesecNetDbContext())
            {
                List<Team> teams = db.Teams.ToList();
                return teams;
                
            }
        }
    }
}
