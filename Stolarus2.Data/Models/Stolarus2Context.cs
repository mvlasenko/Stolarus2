using Stolarus2.Data.Models.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Stolarus2.Data.Models
{
    public class Stolarus2Context : DbContext
    {
        public Stolarus2Context()
        {
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SliderMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new PortfolioTypeMap());
            modelBuilder.Configurations.Add(new PortfolioMap());
            modelBuilder.Configurations.Add(new PortfolioDetailMap());
            modelBuilder.Configurations.Add(new ArticleMap());
            modelBuilder.Configurations.Add(new QuoteMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new CertificateMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}