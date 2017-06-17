namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixRoleModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Positions", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles");
            DropIndex("dbo.Positions", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "Role_Id" });
            DropPrimaryKey("dbo.Roles");
            DropPrimaryKey("dbo.UserRoles");
            AlterColumn("dbo.Roles", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Positions", "RoleId", c => c.Int(nullable: false));
            AlterColumn("dbo.UserRoles", "Role_Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Roles", "Id");
            AddPrimaryKey("dbo.UserRoles", new[] { "Role_Id", "User_Id" });
            CreateIndex("dbo.Positions", "RoleId");
            CreateIndex("dbo.UserRoles", "Role_Id");
            AddForeignKey("dbo.Positions", "RoleId", "dbo.Roles", "Id", cascadeDelete: false);
            AddForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles", "Id", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Positions", "RoleId", "dbo.Roles");
            DropIndex("dbo.UserRoles", new[] { "Role_Id" });
            DropIndex("dbo.Positions", new[] { "RoleId" });
            DropPrimaryKey("dbo.UserRoles");
            DropPrimaryKey("dbo.Roles");
            AlterColumn("dbo.UserRoles", "Role_Id", c => c.Byte(nullable: false));
            AlterColumn("dbo.Positions", "RoleId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Roles", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.UserRoles", new[] { "Role_Id", "User_Id" });
            AddPrimaryKey("dbo.Roles", "Id");
            CreateIndex("dbo.UserRoles", "Role_Id");
            CreateIndex("dbo.Positions", "RoleId");
            AddForeignKey("dbo.UserRoles", "Role_Id", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Positions", "RoleId", "dbo.Roles", "Id", cascadeDelete: true);
        }
    }
}
