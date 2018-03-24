using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class PortfolioDetailsController : ApiController<PortfolioDetail, int>
    {
        public PortfolioDetailsController() : base(DependencyResolver.Current.GetService<IPortfolioDetailsRepository>())
        {

        }
    }
}