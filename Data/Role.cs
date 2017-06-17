using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Role
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        public virtual ICollection<UserRole> UsersRoles { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

        public Role()
        {
            UsersRoles = new HashSet<UserRole>();
            Positions = new HashSet<Position>();
        }
    }
}
