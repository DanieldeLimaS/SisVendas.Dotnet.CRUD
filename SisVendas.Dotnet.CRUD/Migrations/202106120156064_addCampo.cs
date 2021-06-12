namespace UI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCampo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ItensVendas", "ValorVendido", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ItensVendas", "ValorVendido");
        }
    }
}
