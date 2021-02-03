using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        public DbSet<Cidade> Cidades { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }

        public DbSet<ProdutoCategoria> ProdutoCategorias { get; set; }

        public DbSet<ProdutoPromocao> ProdutoPromocoes { get; set; }

        public DbSet<Combo> Combos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}