using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class PortfolioTypesController : ApplicationController<PortfolioType, int>
    {
        private IPortfolioTypesRepository repository;

        public PortfolioTypesController(IPortfolioTypesRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public override ActionResult CreatePartial(PortfolioType entity)
        {
            entity.CreatedDateTime = DateTime.Now;
            return base.CreatePartial(entity);
        }
    }
}
