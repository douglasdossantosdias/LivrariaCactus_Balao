using LivrariaCactus_Balao.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace LivrariaCactus_Balao.AcessoDados {
    public class LivroContexto : DbContext{

        public LivroContexto():base("DefaultConnection")
        {
           // Database.SetInitializer<LivroContexto>(new CreateDatabaseIfNotExists<LivroContexto>());
        }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Properties<string>().Configure(c => c.HasMaxLength(100));
        }

    }
}