using System;
using System.Web.Mvc;
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

        public override ActionResult CreatePartial(ArticleCategory entity)
        {
            entity.CreatedDateTime = DateTime.Now;
            return base.CreatePartial(entity);
        }
    }
}
