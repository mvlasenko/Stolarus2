using System;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;

namespace Stolarus2.Admin.Controllers
{
    public abstract class ApplicationController<T, TKey> : Controller where T : class, IEntity<TKey>, new()
    {
        private readonly IRepository<T, TKey> repository;

        protected ApplicationController(IRepository<T, TKey> repository)
        {
            this.repository = repository;
        }

        protected virtual IPagedCollection LoadCollection(IFilter<T, TKey> filter)
        {
            return repository.GetPaged(filter);
        }

        protected virtual dynamic LoadModel(TKey id)
        {
            return repository.GetById(id);
        }

        protected virtual RedirectToRouteResult RedirectToCollectionUrl()
        {
            return RedirectToAction("Index");
        }

        protected virtual RedirectToRouteResult RedirectToResourceUrl(T resource)
        {
            return RedirectToAction("Show", new { @id = resource.Id });
        }

        protected virtual RedirectToRouteResult RedirectToDefaultUrl(T resource)
        {
            return RedirectToCollectionUrl();
        }

        [HttpGet]
        public virtual ActionResult Index(IFilter<T, TKey> filter)
        {
            IPagedCollection model = this.LoadCollection(filter);
            return View("Index", model);
        }

        [HttpGet]
        public virtual ActionResult Show(TKey id)
        {
            dynamic model = this.LoadModel(id);
            return ObjectOr404("Show", model);
        }

        [HttpGet, ValidateInput(false)]
        public virtual ActionResult Create()
        {
            T model = new T();
            return View("New", model);
        }

        [HttpPost, ValidateInput(false)]
        public virtual ActionResult Create(T entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    entity = repository.Insert(entity);
                    return RedirectToDefaultUrl(entity);
                }
                catch (Exception ex)
                {
                    //SiteLogger.Error("Exception occurred in {2}: {0}\r\n{1}", LoggingCategory.General, ex.Message, ex.StackTrace, this.GetType().Name);
                    throw;
                }
            }

            return View("New", entity);
        }

        [HttpGet, ValidateInput(false)]
        public virtual ActionResult CreatePartial()
        {
            T entity = new T();
            return PartialView("_CreatePartial", entity);
        }

        [HttpPost, ValidateInput(false)]
        public virtual ActionResult CreatePartial(T entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repository.Insert(entity);
                    return Json(new { success = true });
                }
                catch (Exception ex)
                {
                    //SiteLogger.Error("Exception occurred in {2}: {0}\r\n{1}", LoggingCategory.General, ex.Message, ex.StackTrace, this.GetType().Name);
                    throw;
                }
            }

            return Json(new { success = false });
        }

        [HttpGet, ValidateInput(false)]
        public virtual ActionResult Update(TKey id)
        {
            dynamic model = this.LoadModel(id);
            return ObjectOr404("Edit", model);
        }

        [HttpPut, ValidateInput(false)]
        public virtual ActionResult Update(TKey id, T entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    entity = repository.Update(entity);
                    return RedirectToDefaultUrl(entity);
                }
                catch (Exception ex)
                {
                    //SiteLogger.Error("Exception occurred in {2}: {0}\r\n{1}", LoggingCategory.General, ex.Message, ex.StackTrace, this.GetType().Name);
                    throw;
                }
            }

            return View("Edit", entity);
        }

        [HttpGet, ValidateInput(false)]
        public virtual ActionResult UpdatePartial(TKey id)
        {
            dynamic entity = this.LoadModel(id);
            return PartialView("_EditPartial", entity);
        }

        [HttpPost, ValidateInput(false)]
        public virtual ActionResult UpdatePartial(TKey id, T entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repository.Update(entity);
                    return Json(new { success = true });
                }
                catch (Exception ex)
                {
                    //SiteLogger.Error("Exception occurred in {2}: {0}\r\n{1}", LoggingCategory.General, ex.Message, ex.StackTrace, this.GetType().Name);
                    throw;
                }
            }

            return Json(new { success = false });
        }

        public virtual ActionResult Destroy(TKey id)
        {
            try
            {
                T entity = repository.GetById(id);
                repository.Delete(entity);
            }
            catch (Exception ex)
            {
                //SiteLogger.Error("Exception occurred in {2}: {0}\r\n{1}", LoggingCategory.General, ex.Message, ex.StackTrace, this.GetType().Name);
                throw;
            }

            return RedirectToCollectionUrl();
        }

        [HttpGet]
        public virtual JsonResult GetList()
        {
            var list = repository.GetList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        protected virtual ActionResult ObjectOr404(object entity)
        {
            return ObjectOr404(null, entity);
        }

        protected virtual ActionResult ObjectOr404(string viewName, object entity)
        {
            if (entity == null)
            {
                return new HttpNotFoundResult();
            }
            else
            {
                return View(viewName, entity);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && repository != null)
            {
                repository.Dispose();
            }

            base.Dispose(disposing);
        }

    }
}