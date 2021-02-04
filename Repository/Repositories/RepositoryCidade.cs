using Domain.Entities;
using Domain.Interfaces.Repositories;
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