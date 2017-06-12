using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Position
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public byte RoleId { get; set; }
        public virtual Role Role { get; set; }
        public virtual ICollection<UserTeam> UsersTeams { get; set; }
        
        public Position()
        {
            UsersTeams = new HashSet<UserTeam>();
        }        
    }
}
