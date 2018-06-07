using System;
using System.Linq;
using System.Web.Mvc;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin.Controllers
{
    public class TranslationsController : ApplicationController<Translation, int>
    {
        private ITranslationsRepository repository;

        public TranslationsController(ITranslationsRepository repository) : base(repository)
        {
            this.repository = repository;
        }

        public virtual JsonResult GetEntityList(string table, string field)
        {
            Table t = (Table)Enum.Parse(typeof(Table), table);
            Field f = (Field)Enum.Parse(typeof(Field), field);

            if (t == Table.Articles)
            {
                IArticleRepository repository = DependencyResolver.Current.GetService<IArticleRepository>();
                if(f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
                if (f == Field.Description)
                    return Json(repository.GetList().Select(x => new { x.Id, Name = x.Description }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Certificates)
            {
                ICertificatesRepository repository = DependencyResolver.Current.GetService<ICertificatesRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Contacts)
            {
                IContactsRepository repository = DependencyResolver.Current.GetService<IContactsRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
                if (f == Field.Description)
                    return Json(repository.GetList().Select(x => new { x.Id, Name = x.Description }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Images)
            {
                IImagesRepository repository = DependencyResolver.Current.GetService<IImagesRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Languages)
            {
                ILanguagesRepository repository = DependencyResolver.Current.GetService<ILanguagesRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.PortfolioDetails)
            {
                IPortfolioDetailsRepository repository = DependencyResolver.Current.GetService<IPortfolioDetailsRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Portfolios)
            {
                IPortfoliosRepository repository = DependencyResolver.Current.GetService<IPortfoliosRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
                if (f == Field.Description)
                    return Json(repository.GetList().Select(x => new { x.Id, Name = x.Description }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.ProductCategories)
            {
                IProductCategoriesRepository repository = DependencyResolver.Current.GetService<IProductCategoriesRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
                if (f == Field.Description)
                    return Json(repository.GetList().Select(x => new { x.Id, Name = x.Description }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Products)
            {
                IProductsRepository repository = DependencyResolver.Current.GetService<IProductsRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
                if (f == Field.Description)
                    return Json(repository.GetList().Select(x => new { x.Id, Name = x.Description }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Quotes)
            {
                IQuotesRepository repository = DependencyResolver.Current.GetService<IQuotesRepository>();
                if (f == Field.Description)
                    return Json(repository.GetList().Select(x => new { x.Id, Name = x.Description }), JsonRequestBehavior.AllowGet);
            }
            if (t == Table.Sliders)
            {
                ISlidersRepository repository = DependencyResolver.Current.GetService<ISlidersRepository>();
                if (f == Field.Name)
                    return Json(repository.GetList().Select(x => new { x.Id, x.Name }), JsonRequestBehavior.AllowGet);
            }

            return Json("", JsonRequestBehavior.AllowGet);
        }

        public virtual JsonResult GetTranslation(string table, string field, int? entityId)
        {
            Table t = (Table)Enum.Parse(typeof(Table), table);
            Field f = (Field)Enum.Parse(typeof(Field), field);

            Translation translation = this.repository.GetList().Where(x => x.Table == t && x.Field == f && x.EntityID == entityId).FirstOrDefault();

            if (translation == null)
                return Json(translation, JsonRequestBehavior.AllowGet);

            SetOriginalValue((int)entityId, t, f, translation);

            return Json(translation, JsonRequestBehavior.AllowGet);
        }

        public virtual JsonResult GetTranslationById(int id)
        {
            Translation translation = this.repository.GetById(id);

            SetOriginalValue(translation.EntityID, translation.Table, translation.Field, translation);

            return Json(translation, JsonRequestBehavior.AllowGet);
        }

        private static void SetOriginalValue(int entityId, Table t, Field f, Translation translation)
        {
            if (t == Table.Articles)
            {
                IArticleRepository repository = DependencyResolver.Current.GetService<IArticleRepository>();
                Article item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
                if (item != null && f == Field.Description)
                    translation.Original = item.Description;
            }
            if (t == Table.Certificates)
            {
                ICertificatesRepository repository = DependencyResolver.Current.GetService<ICertificatesRepository>();
                Certificate item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
            }
            if (t == Table.Contacts)
            {
                IContactsRepository repository = DependencyResolver.Current.GetService<IContactsRepository>();
                Contact item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
                if (item != null && f == Field.Description)
                    translation.Original = item.Description;
            }
            if (t == Table.Languages)
            {
                ILanguagesRepository repository = DependencyResolver.Current.GetService<ILanguagesRepository>();
                Language item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
            }
            if (t == Table.PortfolioDetails)
            {
                IPortfolioDetailsRepository repository = DependencyResolver.Current.GetService<IPortfolioDetailsRepository>();
                PortfolioDetail item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
            }
            if (t == Table.Portfolios)
            {
                IPortfoliosRepository repository = DependencyResolver.Current.GetService<IPortfoliosRepository>();
                Portfolio item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
                if (item != null && f == Field.Description)
                    translation.Original = item.Description;
            }
            if (t == Table.ProductCategories)
            {
                IProductCategoriesRepository repository = DependencyResolver.Current.GetService<IProductCategoriesRepository>();
                ProductCategory item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
                if (item != null && f == Field.Description)
                    translation.Original = item.Description;
            }
            if (t == Table.Products)
            {
                IProductsRepository repository = DependencyResolver.Current.GetService<IProductsRepository>();
                Product item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
                if (item != null && f == Field.Description)
                    translation.Original = item.Description;
            }
            if (t == Table.Quotes)
            {
                IQuotesRepository repository = DependencyResolver.Current.GetService<IQuotesRepository>();
                Quote item = repository.GetById(entityId);
                if (item != null && f == Field.Description)
                    translation.Original = item.Description;
            }
            if (t == Table.Sliders)
            {
                ISlidersRepository repository = DependencyResolver.Current.GetService<ISlidersRepository>();
                Slider item = repository.GetById(entityId);
                if (item != null && f == Field.Name)
                    translation.Original = item.Name;
            }
        }

    }
}
