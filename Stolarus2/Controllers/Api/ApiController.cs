using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Controllers.Api
{
    public abstract class ApiController<T, TKey> : ApiController where T : class, IEntity<TKey>, new()
    {
        private readonly IRepository<T, TKey> repository;

        public ApiController(IRepository<T, TKey> repository)
        {
            this.repository = repository;
        }

        public virtual List<T> Get()
        {
            List<T> list = this.repository.GetList().ToList();
            return list;
        }

        public virtual T Get(TKey id)
        {
            T item = repository.GetById(id);
            return item;
        }
    }
}