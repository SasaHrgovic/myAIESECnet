using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class MeetingType
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required]
        public bool Mandatory { get; set; }
        public virtual ICollection<Meeting> Meetings { get; set; }
    }
}