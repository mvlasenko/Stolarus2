using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class TranslationsRepository: RepositoryBase<Translation, int>, ITranslationsRepository
    {
        public TranslationsRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}