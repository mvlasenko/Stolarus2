using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class ArticleMap : EntityTypeConfiguration<Article>
    {
        public ArticleMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.ArticleCategory);

            this.Property(t => t.Name).IsRequired().HasMaxLength(255);

            this.Property(t => t.ImageID).HasMaxLength(255);

            this.Property(t => t.Description).HasMaxLength(1023);

            this.Property(t => t.Body).HasMaxLength(4000);

            this.Property(t => t.CreatedDateTime).IsRequired();

            this.Property(t => t.SeqID);

            // Table & Column Mappings

            this.ToTable("Article");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ArticleCategory).HasColumnName("ArticleCategory");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Body).HasColumnName("Body");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.SeqID).HasColumnName("SeqID");
        }
    }
}