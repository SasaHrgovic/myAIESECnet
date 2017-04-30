namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 1000),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        CommitteeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Committees", t => t.CommitteeId, cascadeDelete: true)
                .Index(t => t.CommitteeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teams", "CommitteeId", "dbo.Committees");
            DropIndex("dbo.Teams", new[] { "CommitteeId" });
            DropTable("dbo.Teams");
        }
    }
}
