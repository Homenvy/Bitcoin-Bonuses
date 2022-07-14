namespace Bitcoin_Bonuses.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BonusType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bitcoins", "BonusType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bitcoins", "BonusType");
        }
    }
}
