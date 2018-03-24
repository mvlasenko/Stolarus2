using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class ArticleCategoryMap : EntityTypeConfiguration<ArticleCategory>
    {
        public ArticleCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.Code).IsRequired().HasMaxLength(50);

            this.Property(t => t.Name).IsRequired().HasMaxLength(255);

            this.Property(t => t.ImageURL).HasMaxLength(255);

            this.Property(t => t.Description).HasMaxLength(1023);

            this.Property(t => t.CreatedDateTime).IsRequired();

            this.Property(t => t.SeqID);

            // Table & Column Mappings

            this.ToTable("ArticleCategories");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImageURL).HasColumnName("ImageURL");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.SeqID).HasColumnName("SeqID");

            // Relationships
            this.HasMany(e => e.Article)
                .WithOptional(e => e.ArticleCategory)
                .WillCascadeOnDelete(false);

        }
    }
}