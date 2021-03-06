using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Data.Repository
{
    public class CertificatesRepository: RepositoryBase<Certificate, int>, ICertificatesRepository
    {
        public CertificatesRepository(IDbContextFactory factory) : base(factory)
        {
        }
    }
}