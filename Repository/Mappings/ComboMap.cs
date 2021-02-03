using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ComboMap : BaseMap<Combo>
    {
        public ComboMap() : base("tb_produto_combo")
        {
        }

        public override void Configure(EntityTypeBuilder<Combo> builder)
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

            builder.Property(x => x.IdImagem)
                .HasColumnName("id_imagem");

            // For Mapping One To Many
            builder.HasOne(x => x.Imagem)
                .WithMany()
                .HasForeignKey(x => x.IdImagem);

            // For Mapping Many To Many
            builder.HasMany(x => x.Produtos)
                .WithMany(x => x.Combos)
                .UsingEntity<ComboProduto>(
                    x => x.HasOne(y => y.Produto).WithMany().HasForeignKey(y => y.IdProduto),
                    x => x.HasOne(y => y.Combo).WithMany().HasForeignKey(y => y.IdCombo),
                    x =>
                        {
                            x.ToTable("tb_combo_produto");
                            x.HasKey(z => new { z.IdCombo, z.IdProduto });
                            x.Property(x => x.IdCombo).HasColumnName("id_combo").IsRequired();
                            x.Property(x => x.IdProduto).HasColumnName("id_produto").IsRequired();
                        }
                );
        }
    }
}