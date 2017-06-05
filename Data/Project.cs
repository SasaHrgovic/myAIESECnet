using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Project
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<TeamProject> TeamsProjects { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }

        public Project()
        {
            TeamsProjects = new HashSet<TeamProject>();
            Activities = new HashSet<Activity>();
        }
    }
}
