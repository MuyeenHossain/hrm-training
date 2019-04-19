namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Designation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ShortName = c.String(),
                        DesignationName = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Designations");
        }
    }
}
