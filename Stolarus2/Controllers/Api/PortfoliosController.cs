using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class PortfoliosController : ApiController<Portfolio, int>
    {
        public PortfoliosController() : base(DependencyResolver.Current.GetService<IPortfoliosRepository>())
        {

        }
    }
}