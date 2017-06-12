using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ConferenceUser
    {
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Key, Column(Order = 2)]
        public int ConferenceId { get; set; }
        public virtual Conference Conference { get; set; }
    }
}
