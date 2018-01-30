using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(512);

            // Table & Column Mappings

            this.ToTable("Products");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships

            this.HasOptional(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CategoryId);

        }
    }
}