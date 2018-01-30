using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class CategoriesRepository: RepositoryBase<Category, int>, ICategoriesRepository
    {
        public CategoriesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}