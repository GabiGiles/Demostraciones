namespace WindowsEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producto",
                c => new
                    {
                        ProductoId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Precio = c.Decimal(nullable: false, storeType: "money"),
                        IdCategoria = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductoId)
                .ForeignKey("dbo.Categoria", t => t.IdCategoria, cascadeDelete: true)
                .Index(t => t.IdCategoria);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        SID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.SID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Producto", "IdCategoria", "dbo.Categoria");
            DropIndex("dbo.Producto", new[] { "IdCategoria" });
            DropTable("dbo.Empleado");
            DropTable("dbo.Producto");
            DropTable("dbo.Categoria");
        }
    }
}
