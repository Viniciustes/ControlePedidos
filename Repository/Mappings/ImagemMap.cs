using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ImagemMap : BaseMap<Imagem>
    {
        public ImagemMap() : base("tb_imagem")
        {
        }

        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Arquivo)
                .HasColumnName("arquivo")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Principal)
                .HasColumnName("principal")
                .HasDefaultValue(false)
                .IsRequired();
        }
    }
}