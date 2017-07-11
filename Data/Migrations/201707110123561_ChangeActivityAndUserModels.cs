namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeActivityAndUserModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserActivities", "User_Id", "dbo.Users");
            DropForeignKey("dbo.UserActivities", "Activity_Id", "dbo.Activities");
            DropIndex("dbo.UserActivities", new[] { "User_Id" });
            DropIndex("dbo.UserActivities", new[] { "Activity_Id" });
            DropTable("dbo.UserActivities");
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        ActivityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.ActivityId })
                .ForeignKey("dbo.Activities", t => t.ActivityId, cascadeDelete: false)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: false)
                .Index(t => t.UserId)
                .Index(t => t.ActivityId);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserActivities", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserActivities", "ActivityId", "dbo.Activities");
            DropIndex("dbo.UserActivities", new[] { "UserId" });
            DropIndex("dbo.UserActivities", new[] { "ActivityId" });
            DropTable("dbo.UserActivities");
            CreateTable(
                "dbo.UserActivities",
                c => new
                    {
                        User_Id = c.Int(nullable: false),
                        Activity_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.User_Id, t.Activity_Id });
            
            CreateIndex("dbo.UserActivities", "Activity_Id");
            CreateIndex("dbo.UserActivities", "User_Id");
            AddForeignKey("dbo.UserActivities", "Activity_Id", "dbo.Activities", "Id", cascadeDelete: false);
            AddForeignKey("dbo.UserActivities", "User_Id", "dbo.Users", "Id", cascadeDelete: false);
        }
    }
}
