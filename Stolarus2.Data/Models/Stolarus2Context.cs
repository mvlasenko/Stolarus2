using Stolarus2.Data.Models.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Stolarus2.Data.Models
{
    public class Stolarus2Context : DbContext
    {
        //public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());


            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
