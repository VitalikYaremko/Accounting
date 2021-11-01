namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        RegistrationNumber = c.Int(nullable: false),
                        FullName = c.String(),
                        Gender = c.String(),
                        Birthday = c.DateTime(nullable: false),
                        IsExternalEmployee = c.Boolean(nullable: false),
                        PositionName = c.String(),
                        Position_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Positions", t => t.Position_Id)
                .Index(t => t.Position_Id);
            
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        BaseSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Position_Id", "dbo.Positions");
            DropIndex("dbo.Employees", new[] { "Position_Id" });
            DropTable("dbo.Positions");
            DropTable("dbo.Employees");
        }
    }
}
