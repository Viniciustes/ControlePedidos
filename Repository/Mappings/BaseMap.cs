using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Mappings
{
    public class BaseMap<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        private readonly string _tableName;

        public BaseMap(string tableName = null)
        {
            _tableName = tableName;
        }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            if (!string.IsNullOrWhiteSpace(_tableName))
            {
                builder.ToTable(_tableName);
            }

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(x => x.DataCadastro)
                .HasColumnName("data_cadastro")
                .IsRequired();
        }
    }
}