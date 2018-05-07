using System.Linq;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.ViewModels;

namespace Stolarus2.Controllers
{
    public class ProductCategoriesController : Controller
    {
        public ActionResult Index()
        {
            ProductCategoriesInfo model = new ProductCategoriesInfo();

            IProductCategoriesRepository productCategoryRepository = DependencyResolver.Current.GetService<IProductCategoriesRepository>();
            model.ProductCategories = productCategoryRepository.GetList().ToList();

            return View(model);
        }
    }
}