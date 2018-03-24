using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ContactsController : ApplicationController<Contact, int>
    {
        private IContactsRepository repository;

        public ContactsController(IContactsRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
