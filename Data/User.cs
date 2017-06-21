using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class User
    {
        public int Id { get; set; }
        [Required, StringLength(30)]
        public string Name { get; set; }
        [Required, StringLength(30)]
        public string Surname { get; set; }
        [Required, StringLength(30), Index(IsUnique = true)]
        public string Email { get; set; }
        [Required, StringLength(255)]
        public string Password { get; set; }
        [Required, StringLength(15)]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public virtual ICollection<UserRole> UsersRoles { get; set; }
        public virtual Committee Committee { get; set; }
        public int CommitteeId { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<UserTeam> UsersTeams { get; set; }
        public virtual ICollection<MeetingUser> MeetingsUsers { get; set; }
        public virtual ICollection<ConferenceUser> ConferencesUsers { get; set; }
        public string FullName { get { return Name + " " + Surname; } }

        public User()
        {
            UsersRoles = new HashSet<UserRole>();
            Activities = new HashSet<Activity>();
            UsersTeams = new HashSet<UserTeam>();
            MeetingsUsers = new HashSet<MeetingUser>();
            ConferencesUsers = new HashSet<ConferenceUser>();
            
        }
    }
}
