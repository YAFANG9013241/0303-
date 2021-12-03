namespace _0303人事行政局放假資料.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class descriptionMaxLength200 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.holidays", "description", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.holidays", "description", c => c.String(maxLength: 50));
        }
    }
}
