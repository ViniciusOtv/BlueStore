namespace LojaVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atualizacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DataNascimento", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "MyProperty", c => c.DateTime(nullable: false));
            DropColumn("dbo.AspNetUsers", "DataNascimento");
        }
    }
}
