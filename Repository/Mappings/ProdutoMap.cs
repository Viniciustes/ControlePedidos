using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ProdutoMap : BaseMap<Produto>
    {
        public ProdutoMap() : base("tb_produto")
        {
        }

        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Codigo)
                .HasColumnName("codigo")
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnName("preco")
                .HasPrecision(17, 2)
                .IsRequired();

            builder.Property(x => x.Ativo)
                .HasColumnName("ativo")
                .IsRequired();

            builder.Property(x => x.IdCategoria)
                .HasColumnName("id_categoria");

            // For Mapping One To Many Bidirectional
            builder.HasOne(x => x.Categoria)
                .WithMany(x => x.Produtos)
                .HasForeignKey(x => x.IdCategoria);

            // For Mapping Many To Many
            builder.HasMany(x => x.Imagens)
                .WithMany(x => x.Produtos)
                .UsingEntity<ImagemProduto>
                (
                    x => x.HasOne(y => y.Imagem).WithMany().HasForeignKey(y => y.IdImagem),
                    x => x.HasOne(y => y.Produto).WithMany().HasForeignKey(y => y.IdProduto),
                    x =>
                    {
                        x.ToTable("tb_imagem_produto");
                        x.HasKey(y => new { y.IdImagem, y.IdProduto });
                        x.Property(y => y.IdImagem).HasColumnName("id_imagem").IsRequired();
                        x.Property(y => y.IdProduto).HasColumnName("id_produto").IsRequired();
                    }
                );
        }
    }
}