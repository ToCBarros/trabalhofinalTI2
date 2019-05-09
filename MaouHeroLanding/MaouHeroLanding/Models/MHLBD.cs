using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MaouHeroLanding.Models
{
    public class MHLBD : DbContext
    {
        public MHLBD() : base("MHLDBConnectionString")
        {

        }

        public virtual DbSet<Artigos> Artigos { get; set; } // tabela Artigos
        public virtual DbSet<Clientes> Clientes { get; set; } // tabela Clientes
        public virtual DbSet<Compras> Compras { get; set; } // tabela Compras
        public virtual DbSet<Encomendas> Encomendas { get; set; } // tabela Encomendas
        public virtual DbSet<Funcionarios> Funcionarios { get; set; } // tabela Funcionarios
        public virtual DbSet<Gestores> Gestores { get; set; } // tabela Gestores


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
