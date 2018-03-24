using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class SlidersController : ApplicationController<Slider, int>
    {
        private ISlidersRepository repository;

        public SlidersController(ISlidersRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
