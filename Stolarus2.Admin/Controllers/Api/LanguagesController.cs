using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers.Api
{
    public class LanguagesController : ApiController<Language, int>
    {
        public LanguagesController() : base(DependencyResolver.Current.GetService<ILanguagesRepository>())
        {

        }
    }
}