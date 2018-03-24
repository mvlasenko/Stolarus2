using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class SlidersController : ApiController<Slider, int>
    {
        public SlidersController() : base(DependencyResolver.Current.GetService<ISlidersRepository>())
        {

        }
    }
}