using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class PedidoMap : BaseMap<Pedido>
    {
        public PedidoMap() : base("tb_pedido")
        {
        }

        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Numero)
                .HasColumnName("numero")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.ValorPedido)
                .HasColumnName("valor_pedido")
                .HasPrecision(17, 2)
                .IsRequired();

            builder.Property(x => x.Entrega)
                .HasColumnName("entrega");

            builder.Property(x => x.IdCliente)
                .HasColumnName("id_cliente")
                .IsRequired();

            // For Mapping One To Many Bidirectional
            builder.HasOne(x => x.Cliente)
                .WithMany(x => x.Pedidos)
                .HasForeignKey(x => x.IdCliente);
        }
    }
}