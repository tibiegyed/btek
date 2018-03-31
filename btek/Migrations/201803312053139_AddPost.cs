namespace btek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdPostModels",
                c => new
                    {
                        AdId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        Address = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.AdId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AdPostModels");
        }
    }
}
