namespace WebAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Umur = c.Int(nullable: false),
                        Alamat = c.String(),
                        DepartementID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartementID, cascadeDelete: true)
                .Index(t => t.DepartementID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DepartementID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartementID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
