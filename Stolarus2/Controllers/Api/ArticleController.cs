using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class ArticleController : ApiController<Article, int>
    {
        public ArticleController() : base(DependencyResolver.Current.GetService<IArticleRepository>())
        {

        }
    }
}