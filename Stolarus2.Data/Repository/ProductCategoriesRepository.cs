using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class ProductCategoriesRepository: RepositoryBase<ProductCategory, int>, IProductCategoriesRepository
    {
        public ProductCategoriesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}