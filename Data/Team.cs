using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Team
    {
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required, StringLength(1000)]
        public string Description { get; set; }
        [Required]
        public DateTime Start { get; set; }
        [Required]
        public DateTime End { get; set; }
        public Committee Committee { get; set; }
        [Required]
        public int CommitteeId { get; set; }
    }
}
