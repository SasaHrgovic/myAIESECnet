using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Committee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Team> Teams { get; set; }

        public Committee()
        {
            Users = new HashSet<User>();
            Teams = new HashSet<Team>();
        }
    }
}
