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
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new LanguageMap());


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
