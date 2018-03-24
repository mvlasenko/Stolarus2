using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class QuotesController : ApiController<Quote, int>
    {
        public QuotesController() : base(DependencyResolver.Current.GetService<IQuotesRepository>())
        {

        }
    }
}