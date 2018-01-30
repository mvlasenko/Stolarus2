using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class ProductsRepository : RepositoryBase<Product, int>, IProductsRepository
    {
        public ProductsRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}