using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class ProductsApiController : ApiController
    {
        private readonly IProductsRepository _repository;

        public ProductsApiController()
        {
            this._repository = DependencyResolver.Current.GetService<IProductsRepository>();
        }

        // GET: api/ProductsApi
        public List<Product> Get()
        {
            List<Product> list = this._repository.GetList().ToList();
            return list;
        }

        //// GET: api/ProductsApi/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/ProductsApi
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/ProductsApi/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/ProductsApi/5
        //public void Delete(int id)
        //{
        //}
    }
}
