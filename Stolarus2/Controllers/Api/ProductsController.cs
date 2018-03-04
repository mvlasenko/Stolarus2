using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class ProductsController : ApiController<Product, int>
    {
        public ProductsController() : base(DependencyResolver.Current.GetService<IProductsRepository>())
        {

        }
    }
}