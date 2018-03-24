using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class PortfolioDetailsRepository: RepositoryBase<PortfolioDetail, int>, IPortfolioDetailsRepository
    {
        public PortfolioDetailsRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}