using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class ArticleCategoriesController : ApiController<ArticleCategory, int>
    {
        public ArticleCategoriesController() : base(DependencyResolver.Current.GetService<IArticleCategoriesRepository>())
        {

        }
    }
}