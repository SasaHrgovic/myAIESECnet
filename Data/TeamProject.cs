using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class TeamProject
    {
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; }
    }
}