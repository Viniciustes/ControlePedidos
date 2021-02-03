using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class ClienteMap : BaseMap<Cliente>
    {
        public ClienteMap() : base("tb_cliente")
        {
        }

        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome)
                .HasColumnName("nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.CPF)
                .HasColumnName("cpf")
                .HasMaxLength(11)
                .IsRequired();

            builder.Property(x => x.Ativo)
              .HasColumnName("ativo")
              .IsRequired();

            builder.Property(x => x.IdEndereco)
                .HasColumnName("id_endereco")
                .IsRequired();
        }
    }
}