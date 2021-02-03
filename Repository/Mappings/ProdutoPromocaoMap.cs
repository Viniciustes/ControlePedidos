using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ProdutoPromocaoMap : BaseMap<ProdutoPromocao>
    {
        public ProdutoPromocaoMap() : base("tb_produto_promocao")
        {
        }

        public override void Configure(EntityTypeBuilder<ProdutoPromocao> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnName("ativo")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnName("preco")
                .HasPrecision(17, 2)
                .IsRequired();

            builder.Property(x => x.DataValidadePromocao)
                .HasColumnName("data_validade")
                .IsRequired();

            builder.Property(x => x.IdImagem)
                .HasColumnName("id_imagem");

            builder.Property(x => x.IdProduto)
                .HasColumnName("id_produto");

            // For Mapping One To Many
            builder.HasOne(x => x.Imagem)
                .WithMany()
                .HasForeignKey(x => x.IdImagem);

            // For Mapping One To Many Bidirectional
            builder.HasOne(x => x.Produto)
                .WithMany(x => x.Promocoes)
                .HasForeignKey(x => x.IdProduto);
        }
    }
}