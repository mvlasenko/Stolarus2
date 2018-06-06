using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class LanguagesController : ApplicationController<Language, int>
    {
        private ILanguagesRepository repository;

        public LanguagesController(ILanguagesRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
