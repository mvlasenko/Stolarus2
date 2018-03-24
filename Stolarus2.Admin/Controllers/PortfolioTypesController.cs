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
    }
}
