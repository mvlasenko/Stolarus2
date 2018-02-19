using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Api.Controllers
{
    public class HomePageController : ApiController
    {
        private readonly ICategoriesRepository _repository;

        public HomePageController()
        {
            this._repository = DependencyResolver.Current.GetService<ICategoriesRepository>();
        }

        public IHttpActionResult GetCategories()
        {
            List<Category> list = this._repository.GetList().ToList();
            return Ok(list);
        }
    }
}