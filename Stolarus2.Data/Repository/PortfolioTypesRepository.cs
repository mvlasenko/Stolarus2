using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class PortfolioTypesRepository: RepositoryBase<PortfolioType, int>, IPortfolioTypesRepository
    {
        public PortfolioTypesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}