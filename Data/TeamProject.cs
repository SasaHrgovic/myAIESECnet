using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data
{
    public class TeamProject
    {
        [Key, Column(Order=1)]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        [Key, Column(Order=2)]
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}