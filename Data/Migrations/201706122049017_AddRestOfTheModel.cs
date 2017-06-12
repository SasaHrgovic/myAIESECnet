namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRestOfTheModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ConferenceUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ConferenceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.ConferenceId })
                .ForeignKey("dbo.Conferences", t => t.ConferenceId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.ConferenceId);
            
            CreateTable(
                "dbo.Conferences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Location = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 1000),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Mandatory = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MeetingUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        MeetingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.MeetingId })
                .ForeignKey("dbo.Meetings", t => t.MeetingId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.MeetingId);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 1000),
                        DateTime = c.DateTime(nullable: false),
                        MeetingTypeId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MeetingTypes", t => t.MeetingTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.MeetingTypeId)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.MeetingTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Mandatory = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 1000),
                        TeamId = c.Int(nullable: false),
                        RoleId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UserTeams",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        TeamId = c.Int(nullable: false),
                        PositionId = c.Int(),
                    })
                .PrimaryKey(t => new { t.UserId, t.TeamId })
                .ForeignKey("dbo.Positions", t => t.PositionId)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.TeamId)
                .Index(t => t.PositionId, unique: true);
            
            AddColumn("dbo.Teams", "Type", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTeams", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserTeams", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.UserTeams", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.Positions", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Positions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.MeetingUsers", "UserId", "dbo.Users");
            DropForeignKey("dbo.Meetings", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Meetings", "MeetingTypeId", "dbo.MeetingTypes");
            DropForeignKey("dbo.MeetingUsers", "MeetingId", "dbo.Meetings");
            DropForeignKey("dbo.ConferenceUsers", "UserId", "dbo.Users");
            DropForeignKey("dbo.ConferenceUsers", "ConferenceId", "dbo.Conferences");
            DropIndex("dbo.UserTeams", new[] { "PositionId" });
            DropIndex("dbo.UserTeams", new[] { "TeamId" });
            DropIndex("dbo.UserTeams", new[] { "UserId" });
            DropIndex("dbo.Positions", new[] { "RoleId" });
            DropIndex("dbo.Positions", new[] { "TeamId" });
            DropIndex("dbo.Meetings", new[] { "TeamId" });
            DropIndex("dbo.Meetings", new[] { "MeetingTypeId" });
            DropIndex("dbo.MeetingUsers", new[] { "MeetingId" });
            DropIndex("dbo.MeetingUsers", new[] { "UserId" });
            DropIndex("dbo.ConferenceUsers", new[] { "ConferenceId" });
            DropIndex("dbo.ConferenceUsers", new[] { "UserId" });
            DropColumn("dbo.Teams", "Type");
            DropTable("dbo.UserTeams");
            DropTable("dbo.Positions");
            DropTable("dbo.MeetingTypes");
            DropTable("dbo.Meetings");
            DropTable("dbo.MeetingUsers");
            DropTable("dbo.Conferences");
            DropTable("dbo.ConferenceUsers");
        }
    }
}
