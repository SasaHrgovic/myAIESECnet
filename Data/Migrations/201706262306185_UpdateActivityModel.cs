namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActivityModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Activities", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Activities", new[] { "ProjectId" });
            AlterColumn("dbo.Activities", "Deadline", c => c.DateTime());
            AlterColumn("dbo.Activities", "Start", c => c.DateTime());
            AlterColumn("dbo.Activities", "End", c => c.DateTime());
            AlterColumn("dbo.Activities", "ProjectId", c => c.Int());
            CreateIndex("dbo.Activities", "ProjectId");
            AddForeignKey("dbo.Activities", "ProjectId", "dbo.Projects", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "ProjectId", "dbo.Projects");
            DropIndex("dbo.Activities", new[] { "ProjectId" });
            AlterColumn("dbo.Activities", "ProjectId", c => c.Int(nullable: false));
            AlterColumn("dbo.Activities", "End", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Activities", "Start", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Activities", "Deadline", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Activities", "ProjectId");
            AddForeignKey("dbo.Activities", "ProjectId", "dbo.Projects", "Id", cascadeDelete: true);
        }
    }
}
