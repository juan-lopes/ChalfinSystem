using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Repositorio.Implementacao.Contexto
{
    public class Context : DbContext
    {
        //public Context()
        //    : base("ChalfinSystem")
        //{

        //}
        public DbSet<Dominio.Advogado.Advogado> Advogados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
        }
    }
}
