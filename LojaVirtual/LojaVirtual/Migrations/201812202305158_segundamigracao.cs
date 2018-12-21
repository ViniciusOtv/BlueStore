namespace LojaVirtual.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segundamigracao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pedidos", "UsuarioId", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "MyProperty", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "primeiroNome", c => c.String());
            AddColumn("dbo.AspNetUsers", "Sobrenome", c => c.String());
            CreateIndex("dbo.Pedidos", "UsuarioId");
            AddForeignKey("dbo.Pedidos", "UsuarioId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pedidos", "UsuarioId", "dbo.AspNetUsers");
            DropIndex("dbo.Pedidos", new[] { "UsuarioId" });
            DropColumn("dbo.AspNetUsers", "Sobrenome");
            DropColumn("dbo.AspNetUsers", "primeiroNome");
            DropColumn("dbo.AspNetUsers", "MyProperty");
            DropColumn("dbo.Pedidos", "UsuarioId");
        }
    }
}
