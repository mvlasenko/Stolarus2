using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ProductsController : ApplicationController<Product, int>
    {
        private IProductsRepository repository;

        public ProductsController(IProductsRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public override ActionResult CreatePartial(Product entity)
        {
            entity.CreatedDateTime = DateTime.Now;
            return base.CreatePartial(entity);
        }
    }
}
