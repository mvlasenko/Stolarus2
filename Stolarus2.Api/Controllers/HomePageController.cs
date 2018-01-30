using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;
using Stolarus2.Data.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Stolarus2.Api.Controllers
{
    public class HomePageController : ApiController
    {
        private readonly ICategoriesRepository _repository;

        public HomePageController()
        {
            IDbContextFactory factory = new DbContextFactory();
            this._repository = new CategoriesRepository(factory);
        }

        public IHttpActionResult GetCategories()
        {
            List<Category> list = this._repository.GetList().ToList();
            return Ok(list);
        }
    }
}
