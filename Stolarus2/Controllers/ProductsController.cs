using System.Linq;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;
using Stolarus2.ViewModels;

namespace Stolarus2.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index(int id)
        {
            ProductsInfo model = new ProductsInfo();

            IProductCategoriesRepository productCategoryRepository = DependencyResolver.Current.GetService<IProductCategoriesRepository>();

            ProductCategory productCategory = productCategoryRepository.GetById(id);

            model.CategoryName = productCategory.Name;
            model.CategoryDescription = productCategory.Description;
            model.Products = productCategory.Products.ToList();

            return View(model);
        }
    }
}