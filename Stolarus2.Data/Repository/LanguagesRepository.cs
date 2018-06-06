using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class LanguagesRepository: RepositoryBase<Language, int>, ILanguagesRepository
    {
        public LanguagesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}