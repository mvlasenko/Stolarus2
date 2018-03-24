using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class CertificatesController : ApplicationController<Certificate, int>
    {
        private ICertificatesRepository repository;

        public CertificatesController(ICertificatesRepository repository) : base(repository)
        {
            this.repository = repository;
        }
    }
}
