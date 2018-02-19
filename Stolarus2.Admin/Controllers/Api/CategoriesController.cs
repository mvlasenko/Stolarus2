using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers.Api
{
    public class CategoriesController : ApiController<Category, int>
    {
        public CategoriesController() : base(DependencyResolver.Current.GetService<ICategoriesRepository>())
        {

        }
    }
}