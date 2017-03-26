using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Role
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
