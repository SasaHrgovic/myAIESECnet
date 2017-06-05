namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActivityClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 1000),
                        Created = c.DateTime(nullable: false),
                        Deadline = c.DateTime(nullable: false),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        TeamId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: false)
                .Index(t => t.TeamId);
            
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Activity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Activity_Id })
                .ForeignKey("dbo.Users", t => t.User_Id, cascadeDelete: true)
                .ForeignKey("dbo.Activities", t => t.Activity_Id, cascadeDelete: true)
                .Index(t => t.User_Id)
                .Index(t => t.Activity_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserActivities", "Activity_Id", "dbo.Activities");
            DropForeignKey("dbo.UserActivities", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Activities", "TeamId", "dbo.Teams");
            DropIndex("dbo.UserActivities", new[] { "Activity_Id" });
            DropIndex("dbo.UserActivities", new[] { "User_Id" });
            DropIndex("dbo.Activities", new[] { "TeamId" });
            DropTable("dbo.UserActivities");
            DropTable("dbo.Activities");
        }
    }
}
