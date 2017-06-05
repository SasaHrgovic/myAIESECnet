namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(maxLength: 1000),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TeamProjects",
                c => new
                    {
                        TeamId = c.Int(nullable: false),
                        ProjectId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TeamId, t.ProjectId })
                .ForeignKey("dbo.Projects", t => t.ProjectId, cascadeDelete: true)
                .ForeignKey("dbo.Teams", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.ProjectId);
            
            AddColumn("dbo.Activities", "ProjectId", c => c.Int(nullable: false));
            CreateIndex("dbo.Activities", "ProjectId");
            AddForeignKey("dbo.Activities", "ProjectId", "dbo.Projects", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamProjects", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.TeamProjects", "ProjectId", "dbo.Projects");
            DropForeignKey("dbo.Activities", "ProjectId", "dbo.Projects");
            DropIndex("dbo.TeamProjects", new[] { "ProjectId" });
            DropIndex("dbo.TeamProjects", new[] { "TeamId" });
            DropIndex("dbo.Activities", new[] { "ProjectId" });
            DropColumn("dbo.Activities", "ProjectId");
            DropTable("dbo.TeamProjects");
            DropTable("dbo.Projects");
        }
    }
}
