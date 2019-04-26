namespace HRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addemployees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "BloodGroup", c => c.String());
            AddColumn("dbo.Employees", "Address", c => c.String());
            AddColumn("dbo.Employees", "DivisionName", c => c.String());
            AddColumn("dbo.Employees", "DeptName", c => c.String());
            AddColumn("dbo.Employees", "MobileNumber", c => c.String());
            AddColumn("dbo.Employees", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Email");
            DropColumn("dbo.Employees", "MobileNumber");
            DropColumn("dbo.Employees", "DeptName");
            DropColumn("dbo.Employees", "DivisionName");
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "BloodGroup");
        }
    }
}
