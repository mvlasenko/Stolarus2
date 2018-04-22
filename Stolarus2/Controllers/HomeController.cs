using Stolarus2.Data.Contracts;
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

            return View(model);
        }
    }
}