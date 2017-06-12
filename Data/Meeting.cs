using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Meeting
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Subject { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public int MeetingTypeId { get; set; }
        public virtual MeetingType MeetingType { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
        public virtual ICollection<MeetingUser> MeetingsUsers { get; set; }

        public Meeting()
        {
            MeetingsUsers = new HashSet<MeetingUser>();
        }



    }
}
