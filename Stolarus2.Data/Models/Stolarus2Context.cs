using Stolarus2.Data.Models.Mapping;
using System.Data.Entity;

namespace Stolarus2.Data.Models
{
    public class Stolarus2Context : DbContext
    {
        static Stolarus2Context()
        {
            Database.SetInitializer<Stolarus2Context>(null);
        }

        public Stolarus2Context() : base("Name=Stolarus2Context")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        //public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
        }

    }
}
