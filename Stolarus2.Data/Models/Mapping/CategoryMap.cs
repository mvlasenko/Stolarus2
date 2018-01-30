using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.Title)
                .IsRequired()
                .HasMaxLength(512);

            // Table & Column Mappings

            this.ToTable("Categories");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships

            this.HasMany(e => e.Products)
                .WithRequired(e => e.Category)
                .WillCascadeOnDelete(false);
        }
    }
}