using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class QuotesRepository: RepositoryBase<Quote, int>, IQuotesRepository
    {
        public QuotesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}