namespace OperasWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operas",
                c => new
                    {
                        OperaId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50, unicode: false),
                        Compositor = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OperaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Operas");
        }
    }
}
