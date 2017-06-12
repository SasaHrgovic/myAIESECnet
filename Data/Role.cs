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
        public byte Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Position> Positions { get; set; }

        public Role()
        {
            Users = new HashSet<User>();
            Positions = new HashSet<Position>();
        }
    }
}
