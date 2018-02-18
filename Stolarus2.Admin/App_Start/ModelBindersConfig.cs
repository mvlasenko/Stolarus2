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
            binders[typeof(IFilter<Category, int>)] = new CategoriesFilterModelBinder();
            binders[typeof(IFilter<Product, int>)] = new ProductsFilterModelBinder();
            binders[typeof(IFilter<Country, int>)] = new CountriesFilterModelBinder();
            binders[typeof(IFilter<Language, int>)] = new LanguagesFilterModelBinder();

            //todo
        }
    }
}