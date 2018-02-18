using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class CountriesRepository: RepositoryBase<Country, int>, ICountriesRepository
    {
        public CountriesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}