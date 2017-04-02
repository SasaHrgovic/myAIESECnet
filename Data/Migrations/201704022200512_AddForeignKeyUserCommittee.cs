namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyUserCommittee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "CommitteeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Users", "CommitteeId");
            AddForeignKey("dbo.Users", "CommitteeId", "dbo.Committees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CommitteeId", "dbo.Committees");
            DropIndex("dbo.Users", new[] { "CommitteeId" });
            DropColumn("dbo.Users", "CommitteeId");
        }
    }
}
