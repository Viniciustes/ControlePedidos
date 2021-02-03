using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ProdutoCategoriaMap : BaseMap<ProdutoCategoria>
    {
        public ProdutoCategoriaMap() : base("tb_produto_categoria")
        {
        }

        public override void Configure(EntityTypeBuilder<ProdutoCategoria> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(40)
                .IsRequired();

            builder.Property(x => x.Ativo)
              .HasColumnName("ativo")
              .IsRequired();
        }
    }
}