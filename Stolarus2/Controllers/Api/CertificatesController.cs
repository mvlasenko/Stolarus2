using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Controllers.Api
{
    public class CertificatesController : ApiController<Certificate, int>
    {
        public CertificatesController() : base(DependencyResolver.Current.GetService<ICertificatesRepository>())
        {

        }
    }
}