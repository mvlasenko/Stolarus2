using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class CountriesController : ApplicationController<Country, int>
    {
        private ICountriesRepository repository;

        public CountriesController(ICountriesRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}

