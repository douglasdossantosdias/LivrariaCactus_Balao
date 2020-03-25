namespace LivrariaCactus_Balao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoDeFuncionamento : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genero",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Livro",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(maxLength: 100),
                        Autor = c.String(maxLength: 100),
                        AnoEdicao = c.Int(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GeneroId = c.Int(nullable: false),
                        Alugado = c.String(maxLength: 1),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genero", t => t.GeneroId, cascadeDelete: true)
                .Index(t => t.GeneroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Livro", "GeneroId", "dbo.Genero");
            DropIndex("dbo.Livro", new[] { "GeneroId" });
            DropTable("dbo.Livro");
            DropTable("dbo.Genero");
        }
    }
}
