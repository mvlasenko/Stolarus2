using System.Web.Http;
using Unity;
using Unity.AspNet.WebApi;
using Stolarus2.Data.Contracts;
using Stolarus2.Data.Repository;

namespace Stolarus2.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = new UnityContainer();


            container.RegisterType<IDbContextFactory, DbContextFactory>();

            container.RegisterType<IProductsRepository, ProductsRepository>();

            container.RegisterType<ICategoriesRepository, CategoriesRepository>();

            container.RegisterType<ICountriesRepository, CountriesRepository>();

            container.RegisterType<ILanguagesRepository, LanguagesRepository>();



            config.DependencyResolver = new UnityDependencyResolver(container);

        }
    }
}
