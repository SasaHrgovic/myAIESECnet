using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MeetingUser
    {
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Key, Column(Order = 2)]
        public int MeetingId { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}
