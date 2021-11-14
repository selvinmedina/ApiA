using ApiA.Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiA.Infraestructure.Maps
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Comentario);
            builder.Property(x => x.Total);
            builder.Property(x => x.Fecha);
            builder.Property(x => x.UsuarioId);

            builder.HasMany(x => x.PedidoDetalles)
                .WithOne(x => x.Pedido)
                .HasForeignKey(x => x.PedidoId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_Pedido_PedidoDetalle");
        }
    }
}
