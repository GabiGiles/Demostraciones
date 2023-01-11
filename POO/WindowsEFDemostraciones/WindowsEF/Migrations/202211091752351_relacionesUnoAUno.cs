namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class relacionesUnoAUno : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDetail",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        Gender = c.String(maxLength: 10),
                        EmailAddress = c.String(maxLength: 255),
                        PhoneNumber = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.EmployeeId)
                .ForeignKey("dbo.Employee", t => t.EmployeeId)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeDetail", "EmployeeId", "dbo.Employee");
            DropIndex("dbo.EmployeeDetail", new[] { "EmployeeId" });
            DropTable("dbo.Employee");
            DropTable("dbo.EmployeeDetail");
        }
    }
}
