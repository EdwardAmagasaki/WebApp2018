namespace do0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.do0Client",
                c => new
                    {
                        do0ClientId = c.Int(nullable: false, identity: true),
                        ClientName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.do0ClientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.do0Client");
        }
    }
}
