namespace btek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m11 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdPostModels", "ClientName", c => c.String());
            AlterColumn("dbo.AdPostModels", "Address", c => c.String());
            AlterColumn("dbo.AdPostModels", "Description", c => c.String());
            AlterColumn("dbo.AdPostModels", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdPostModels", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.AdPostModels", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.AdPostModels", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.AdPostModels", "ClientName", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
