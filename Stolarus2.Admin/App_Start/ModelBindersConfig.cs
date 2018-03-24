using System.Web.Mvc;
using Stolarus2.Admin.ModelBinding;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Models;

namespace Stolarus2.Admin
{
    public class ModelBindersConfig
    {
        public static void RegisterModelBinders(ModelBinderDictionary binders)
        {
            binders[typeof(IFilter<Slider, int>)] = new SlidersFilterModelBinder();
            binders[typeof(IFilter<ProductCategory, int>)] = new ProductCategoriesFilterModelBinder();
            binders[typeof(IFilter<Product, int>)] = new ProductsFilterModelBinder();
            binders[typeof(IFilter<PortfolioType, int>)] = new PortfolioTypesFilterModelBinder();
            binders[typeof(IFilter<Portfolio, int>)] = new PortfoliosFilterModelBinder();
            binders[typeof(IFilter<PortfolioDetail, int>)] = new PortfolioDetailsFilterModelBinder();
            binders[typeof(IFilter<Article, int>)] = new ArticleFilterModelBinder();
            binders[typeof(IFilter<ArticleCategory, int>)] = new ArticleCategoriesFilterModelBinder();
            binders[typeof(IFilter<Quote, int>)] = new QuotesFilterModelBinder();
            binders[typeof(IFilter<Contact, int>)] = new ContactsFilterModelBinder();
            binders[typeof(IFilter<Certificate, int>)] = new CertificatesFilterModelBinder();
        }
    }
}