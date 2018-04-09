using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class PortfoliosController : ApplicationController<Portfolio, int>
    {
        private IPortfoliosRepository repository;

        public PortfoliosController(IPortfoliosRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public override ActionResult CreatePartial(Portfolio entity)
        {
            entity.CreatedDateTime = DateTime.Now;
            return base.CreatePartial(entity);
        }
    }
}
