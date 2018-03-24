using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class QuotesController : ApplicationController<Quote, int>
    {
        private IQuotesRepository repository;

        public QuotesController(IQuotesRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
