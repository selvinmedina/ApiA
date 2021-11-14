using ApiA.Infraestructure.Entities;
using ApiA.Infraestructure.Maps;
using Microsoft.EntityFrameworkCore;

namespace ApiA.Infraestructure
{
    public partial class EcommerceContext : DbContext
    {
        public EcommerceContext(DbContextOptions<EcommerceContext> options)
            : base(options)
        {

        }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<PedidoDetalle> PedidoDetalle { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new PedidoDetalleMap());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
