using System;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Repository;
using Unity;

namespace Stolarus2
{
    public static partial class UnityConfig
    {
        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IDbContextFactory, DbContextFactory>();

            container.RegisterType<ISlidersRepository, SlidersRepository>();
            container.RegisterType<IProductCategoriesRepository, ProductCategoriesRepository>();
            container.RegisterType<IProductsRepository, ProductsRepository>();
            container.RegisterType<IPortfolioTypesRepository, PortfolioTypesRepository>();
            container.RegisterType<IPortfoliosRepository, PortfoliosRepository>();
            container.RegisterType<IPortfolioDetailsRepository, PortfolioDetailsRepository>();
            container.RegisterType<IArticleRepository, ArticleRepository>();
            container.RegisterType<IQuotesRepository, QuotesRepository>();
            container.RegisterType<IContactsRepository, ContactsRepository>();
            container.RegisterType<ICertificatesRepository, CertificatesRepository>();
            container.RegisterType<IImagesRepository, ImagesRepository>();
            container.RegisterType<ILanguagesRepository, LanguagesRepository>();
            container.RegisterType<ITranslationsRepository, TranslationsRepository>();
        }
    }
}