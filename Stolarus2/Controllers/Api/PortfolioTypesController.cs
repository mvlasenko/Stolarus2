using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class PortfolioTypesController : ApiController<PortfolioType, int>
    {
        public PortfolioTypesController() : base(DependencyResolver.Current.GetService<IPortfolioTypesRepository>())
        {

        }
    }
}