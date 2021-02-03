using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class EnderecoMap : BaseMap<Endereco>
    {
        public EnderecoMap() : base("tb_endereco")
        {
        }

        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.TipoEndereco)
                .HasColumnName("tipo_endereco")
                .IsRequired();

            builder.Property(x => x.Logradouro)
                .HasColumnName("logradouro")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.Bairro)
               .HasColumnName("bairro")
               .HasMaxLength(50)
               .IsRequired();

            builder.Property(x => x.CEP)
               .HasColumnName("cep")
               .HasMaxLength(8)
               .IsRequired();

            builder.Property(x => x.Ativo)
               .HasColumnName("ativo")
               .IsRequired();

            builder.Property(x => x.IdCidade)
                .HasColumnName("id_cidade")
                .IsRequired();

            // For Mapping One To One
            builder.HasOne(x => x.Cliente)
                .WithOne(x => x.Endereco)
                .HasForeignKey<Cliente>(x => x.IdEndereco);

            // For Mapping One To Many
            builder.HasOne(x => x.Cidade)
                .WithMany()
                .HasForeignKey(x => x.IdCidade);
        }
    }
}