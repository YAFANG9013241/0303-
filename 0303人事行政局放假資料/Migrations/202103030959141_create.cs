namespace _0303人事行政局放假資料.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.holidays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        date = c.DateTime(),
                        name = c.String(maxLength: 50),
                        isHoliday = c.String(maxLength: 50),
                        holidayCategory = c.String(maxLength: 50),
                        description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.holidays");
        }
    }
}
