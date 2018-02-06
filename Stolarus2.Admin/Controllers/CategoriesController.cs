using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class CategoriesController : ApplicationController<Category, int>
    {
        private ICategoriesRepository repository;

        public CategoriesController(ICategoriesRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}

