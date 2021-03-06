﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Activity
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public int? ProjectId { get; set; }
        public virtual Project Project { get; set; }
        public virtual ICollection<UserActivity> UsersActivities { get; set; }

        public Activity()
        {
            UsersActivities = new HashSet<UserActivity>();
        }
    }
}
