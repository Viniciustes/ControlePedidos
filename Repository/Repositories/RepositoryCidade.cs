using Domain.Entities;
using Interface.Repositories;
using Repository.Contexts;

namespace Repository.Repositories
{
    public class RepositoryCidade : Repository<Cidade>, IRepositoryCidade
    {
        public RepositoryCidade(ApplicationDbContext context) : base(context)
        {
        }
    }
}