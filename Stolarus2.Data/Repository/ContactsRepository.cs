using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class ContactsRepository: RepositoryBase<Contact, int>, IContactsRepository
    {
        public ContactsRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}