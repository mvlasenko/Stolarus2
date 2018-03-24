using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ProductCategoriesController : ApplicationController<ProductCategory, int>
    {
        private IProductCategoriesRepository repository;

        public ProductCategoriesController(IProductCategoriesRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
