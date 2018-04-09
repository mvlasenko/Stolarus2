using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class PortfolioDetailsController : ApplicationController<PortfolioDetail, int>
    {
        private IPortfolioDetailsRepository repository;

        public PortfolioDetailsController(IPortfolioDetailsRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public override ActionResult CreatePartial(PortfolioDetail entity)
        {
            entity.CreatedDateTime = DateTime.Now;
            return base.CreatePartial(entity);
        }
    }
}
