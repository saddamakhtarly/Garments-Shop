namespace EVS341.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        StreetAddress = c.String(nullable: false, maxLength: 255, unicode: false),
                        City_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.City_Id, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.City_Id);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Province_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Provinces", t => t.Province_Id, cascadeDelete: true)
                .Index(t => t.Province_Id);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                        Country_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.Country_Id, cascadeDelete: true)
                .Index(t => t.Country_Id);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.Int(),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        ImageUrl = c.String(maxLength: 300, unicode: false),
                        Department_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Department_Id, cascadeDelete: true)
                .Index(t => t.Department_Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        ImageUrl = c.String(maxLength: 300, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Fabrics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlaceOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 100, unicode: false),
                        Price = c.Single(nullable: false),
                        ImageUrl = c.String(maxLength: 300, unicode: false),
                        SelectedSizeId = c.Int(nullable: false),
                        Status = c.String(),
                        Quantity = c.Int(nullable: false),
                        Login = c.String(),
                        LandLineNo = c.String(),
                        MobileNo = c.String(),
                        FullAddress = c.String(),
                        InvoiceNo = c.String(),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        Price = c.Single(nullable: false),
                        Description = c.String(maxLength: 100, unicode: false),
                        LaunchingDate = c.DateTime(),
                        Fabric_Id = c.Int(),
                        SubCategory_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Fabrics", t => t.Fabric_Id)
                .ForeignKey("dbo.SubCategories", t => t.SubCategory_Id, cascadeDelete: true)
                .Index(t => t.Fabric_Id)
                .Index(t => t.SubCategory_Id);
            
            CreateTable(
                "dbo.ProductImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Caption = c.String(maxLength: 100, unicode: false),
                        Priority = c.Int(nullable: false),
                        Url = c.String(nullable: false, maxLength: 300, unicode: false),
                        Product_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .Index(t => t.Product_Id);
            
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100, unicode: false),
                        ImageUrl = c.String(maxLength: 300, unicode: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoginId = c.String(nullable: false, maxLength: 20, unicode: false),
                        Password = c.String(nullable: false, maxLength: 20, unicode: false),
                        ContactNumber = c.String(maxLength: 20, unicode: false),
                        Email = c.String(maxLength: 255, unicode: false),
                        ImageUrl = c.String(maxLength: 255, unicode: false),
                        BirthDate = c.DateTime(),
                        IsActive = c.Boolean(),
                        Name = c.String(maxLength: 100, unicode: false),
                        SecurityQuestion = c.String(maxLength: 255, unicode: false),
                        SecurityAnswer = c.String(maxLength: 255, unicode: false),
                        Role_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Role_Id, cascadeDelete: true)
                .Index(t => t.Role_Id);
            
            CreateTable(
                "dbo.ProductColors",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Color_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Color_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Colors", t => t.Color_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Color_Id);
            
            CreateTable(
                "dbo.ProductSizes",
                c => new
                    {
                        Product_Id = c.Int(nullable: false),
                        Size_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Product_Id, t.Size_Id })
                .ForeignKey("dbo.Products", t => t.Product_Id, cascadeDelete: true)
                .ForeignKey("dbo.Sizes", t => t.Size_Id, cascadeDelete: true)
                .Index(t => t.Product_Id)
                .Index(t => t.Size_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Role_Id", "dbo.Roles");
            DropForeignKey("dbo.Addresses", "Id", "dbo.Users");
            DropForeignKey("dbo.Products", "SubCategory_Id", "dbo.SubCategories");
            DropForeignKey("dbo.SubCategories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.ProductSizes", "Size_Id", "dbo.Sizes");
            DropForeignKey("dbo.ProductSizes", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.ProductImages", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Products", "Fabric_Id", "dbo.Fabrics");
            DropForeignKey("dbo.ProductColors", "Color_Id", "dbo.Colors");
            DropForeignKey("dbo.ProductColors", "Product_Id", "dbo.Products");
            DropForeignKey("dbo.Categories", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.Addresses", "City_Id", "dbo.Cities");
            DropForeignKey("dbo.Cities", "Province_Id", "dbo.Provinces");
            DropForeignKey("dbo.Provinces", "Country_Id", "dbo.Countries");
            DropIndex("dbo.ProductSizes", new[] { "Size_Id" });
            DropIndex("dbo.ProductSizes", new[] { "Product_Id" });
            DropIndex("dbo.ProductColors", new[] { "Color_Id" });
            DropIndex("dbo.ProductColors", new[] { "Product_Id" });
            DropIndex("dbo.Users", new[] { "Role_Id" });
            DropIndex("dbo.SubCategories", new[] { "Category_Id" });
            DropIndex("dbo.ProductImages", new[] { "Product_Id" });
            DropIndex("dbo.Products", new[] { "SubCategory_Id" });
            DropIndex("dbo.Products", new[] { "Fabric_Id" });
            DropIndex("dbo.Categories", new[] { "Department_Id" });
            DropIndex("dbo.Provinces", new[] { "Country_Id" });
            DropIndex("dbo.Cities", new[] { "Province_Id" });
            DropIndex("dbo.Addresses", new[] { "City_Id" });
            DropIndex("dbo.Addresses", new[] { "Id" });
            DropTable("dbo.ProductSizes");
            DropTable("dbo.ProductColors");
            DropTable("dbo.Users");
            DropTable("dbo.Roles");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Sizes");
            DropTable("dbo.ProductImages");
            DropTable("dbo.Products");
            DropTable("dbo.PlaceOrders");
            DropTable("dbo.Fabrics");
            DropTable("dbo.Colors");
            DropTable("dbo.Departments");
            DropTable("dbo.Categories");
            DropTable("dbo.Countries");
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}
