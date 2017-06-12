using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Conference
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(255)]
        public string Location { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        [Required]
        public bool Mandatory { get; set; }
        public virtual ICollection<ConferenceUser> ConferencesUsers { get; set; }

        public Conference()
        {
            ConferencesUsers = new HashSet<ConferenceUser>();
        }
    }
}
