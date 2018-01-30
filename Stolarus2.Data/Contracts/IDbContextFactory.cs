using System.Data.Entity;

namespace Stolarus2.Data.Contracts
{
    public interface IDbContextFactory
    {
        DbContext GetDbContext();
    }
}
