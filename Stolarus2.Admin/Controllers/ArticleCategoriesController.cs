using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ArticleCategoriesController : ApplicationController<ArticleCategory, int>
    {
        private IArticleCategoriesRepository repository;

        public ArticleCategoriesController(IArticleCategoriesRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
