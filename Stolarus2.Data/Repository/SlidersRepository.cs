using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class SlidersRepository: RepositoryBase<Slider, int>, ISlidersRepository
    {
        public SlidersRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}