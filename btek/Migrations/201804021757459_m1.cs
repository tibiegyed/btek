namespace btek.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AdPostModels", "ClientName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.AdPostModels", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.AdPostModels", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.AdPostModels", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AdPostModels", "Email", c => c.String());
            AlterColumn("dbo.AdPostModels", "Description", c => c.String());
            AlterColumn("dbo.AdPostModels", "Address", c => c.String());
            AlterColumn("dbo.AdPostModels", "ClientName", c => c.String());
        }
    }
}
