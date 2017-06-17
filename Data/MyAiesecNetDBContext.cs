using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MyAiesecNetDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Committee> Committees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TeamProject> TeamsProjects { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Conference> Conferences { get; set; }
        public DbSet<ConferenceUser> ConferencesUsers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<MeetingType> MeetingTypes { get; set; }
        public DbSet<MeetingUser> MeetingsUsers { get; set; }
        public DbSet<UserTeam> UsersTeams { get; set; }
    }
}
