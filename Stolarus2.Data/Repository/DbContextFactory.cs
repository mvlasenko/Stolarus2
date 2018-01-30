using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;
using System.Data.Entity;

namespace Stolarus2.Data.Repository
{
    public class DbContextFactory : IDbContextFactory
    {
        public DbContext GetDbContext()
        {
            return new Stolarus2Context();
        }
    }
}
