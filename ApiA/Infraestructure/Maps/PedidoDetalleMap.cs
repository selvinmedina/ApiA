using ApiA.Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiA.Infraestructure.Maps
{
    public class PedidoDetalleMap : IEntityTypeConfiguration<PedidoDetalle>
    {
        public void Configure(EntityTypeBuilder<PedidoDetalle> builder)
        {
            builder.ToTable("PedidoDetalle");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Precio);
            builder.Property(x => x.ProductoId);
            builder.Property(x => x.SubTotal);
            builder.Property(x => x.PedidoId);

            builder.HasOne(x => x.Pedido)
                .WithMany(x => x.PedidoDetalles)
                .HasForeignKey(x => x.PedidoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_DetallePedido");
        }
    }
}
