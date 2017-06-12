using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Team
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        public int CommitteeId { get; set; }
        public virtual Committee Committee { get; set; }
        [Required]
        public int Type { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<TeamProject> TeamsProjects { get; set; }
        public virtual ICollection<UserTeam> UsersTeams { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

        public Team()
        {
            Activities = new HashSet<Activity>();
            TeamsProjects = new HashSet<TeamProject>();
            UsersTeams = new HashSet<UserTeam>();
            Positions = new HashSet<Position>();
        }
    }
}
