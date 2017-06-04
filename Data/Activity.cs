using System;
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
        public DateTime Deadline { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Team Team { get; set; }
        [Required]
        public int TeamId { get; set; }
        public ICollection<User> Users { get; set; }

        public Activity()
        {
            Users = new HashSet<User>();
        }
    }
}
