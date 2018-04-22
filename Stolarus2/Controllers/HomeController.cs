using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;
using Stolarus2.ViewModels;
using System.Linq;
using System.Web.Mvc;

namespace Stolarus2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SinglePage model = new SinglePage();

            ISlidersRepository slidersRepository = DependencyResolver.Current.GetService<ISlidersRepository>();
            model.Sliders = slidersRepository.GetList().ToList();

            IArticleRepository articleRepository = DependencyResolver.Current.GetService<IArticleRepository>();
            model.About = articleRepository.GetList().Where(x => x.ArticleCategory == ArticleCategory.About).ToList();

            IProductCategoriesRepository productCategoryRepository = DependencyResolver.Current.GetService<IProductCategoriesRepository>();
            model.ProductCategories = productCategoryRepository.GetList().ToList();

            IPortfoliosRepository portfolioRepository = DependencyResolver.Current.GetService<IPortfoliosRepository>();
            model.Portfolios = portfolioRepository.GetList().Take(5).ToList();

            IContactsRepository contactRepository = DependencyResolver.Current.GetService<IContactsRepository>();
            model.Contacts = contactRepository.GetList().ToList();

            return View(model);
        }
    }
}