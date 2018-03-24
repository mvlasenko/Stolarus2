using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ArticleController : ApplicationController<Article, int>
    {
        private IArticleRepository repository;

        public ArticleController(IArticleRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
