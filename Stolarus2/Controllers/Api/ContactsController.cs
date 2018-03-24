using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class ContactsController : ApiController<Contact, int>
    {
        public ContactsController() : base(DependencyResolver.Current.GetService<IContactsRepository>())
        {

        }
    }
}