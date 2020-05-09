namespace PS1_CisnerosAcostaJoseEnrique.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "idCiudad_Id", c => c.Int());
            CreateIndex("dbo.Events", "idCiudad_Id");
            AddForeignKey("dbo.Events", "idCiudad_Id", "dbo.Cities", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "idCiudad_Id", "dbo.Cities");
            DropIndex("dbo.Events", new[] { "idCiudad_Id" });
            DropColumn("dbo.Events", "idCiudad_Id");
        }
    }
}
