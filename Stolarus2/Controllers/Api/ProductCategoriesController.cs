using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class ProductCategoriesController : ApiController<ProductCategory, int>
    {
        public ProductCategoriesController() : base(DependencyResolver.Current.GetService<IProductCategoriesRepository>())
        {

        }
    }
}