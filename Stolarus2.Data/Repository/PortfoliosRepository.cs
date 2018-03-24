using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class PortfoliosRepository: RepositoryBase<Portfolio, int>, IPortfoliosRepository
    {
        public PortfoliosRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}