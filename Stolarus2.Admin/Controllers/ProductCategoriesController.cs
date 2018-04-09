using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ProductCategoriesController : ApplicationController<ProductCategory, int>
    {
        private IProductCategoriesRepository repository;

        public ProductCategoriesController(IProductCategoriesRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public override ActionResult CreatePartial(ProductCategory entity)
        {
            entity.CreatedDateTime = DateTime.Now;
            return base.CreatePartial(entity);
        }
    }
}
