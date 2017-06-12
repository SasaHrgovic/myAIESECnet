using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class UserTeam
    {
        [Key, Column(Order=1)]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Key, Column(Order=2)]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        [Index(IsUnique=true)]
        public int? PositionId { get; set; } 
        public virtual Position Position { get; set; }
    }
}
