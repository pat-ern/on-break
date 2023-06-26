using Microsoft.EntityFrameworkCore;
using Models;

namespace OnBreakWeb
{
    public class DbConnection : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Data Source=DESKTOP-E41HDHI;Initial Catalog=OnBreak;Integrated Security=True;TrustServerCertificate=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public virtual DbSet<ActividadEmpresa> ActividadEmpresa { get; set; }
        public virtual DbSet<Cenas> Cenas { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Cocktail> Cocktail { get; set; }
        public virtual DbSet<CoffeeBreak> CoffeeBreak { get; set; }
        public virtual DbSet<Contrato> Contrato { get; set; }
        public virtual DbSet<ModalidadServicio> ModalidadServicio { get; set; }
        public virtual DbSet<TipoAmbientacion> TipoAmbientacion { get; set; }
        public virtual DbSet<TipoEmpresa> TipoEmpresa { get; set; }
        public virtual DbSet<TipoEvento> TipoEvento { get; set; }

    }
}
