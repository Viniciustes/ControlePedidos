using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ProdutoPedidoMap : BaseMap<ProdutoPedido>
    {
        public ProdutoPedidoMap() : base("tb_produto_pedido")
        {
        }

        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Preco)
                .HasColumnName("preco")
                .HasPrecision(17, 2)
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasColumnName("quantidade")
                .HasPrecision(2)
                .IsRequired();

            builder.Property(x => x.IdProduto)
                .HasColumnName("id_produto")
                .IsRequired();

            builder.Property(x => x.IdPedido)
                .HasColumnName("id_pedido")
                .IsRequired();

            // For Mapping One To Many
            builder.HasOne(x => x.Produto)
                .WithMany()
                .HasForeignKey(x => x.IdProduto);

            // For Mapping One To Many Bidirectional
            builder.HasOne(x => x.Pedido)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.IdPedido);
        }
    }
}