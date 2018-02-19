using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers.Api
{
    public class CountriesController : ApiController<Country, int>
    {
        public CountriesController() : base(DependencyResolver.Current.GetService<ICountriesRepository>())
        {

        }
    }
}