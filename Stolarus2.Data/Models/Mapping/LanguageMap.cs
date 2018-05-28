using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class LanguageMap : EntityTypeConfiguration<Language>
    {
        public LanguageMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.ImageID).HasMaxLength(255);

            this.Property(t => t.Name).IsRequired().HasMaxLength(255);

            this.Property(t => t.Code).IsRequired().HasMaxLength(255);

            this.Property(t => t.Default);

            // Table & Column Mappings

            this.ToTable("Languages");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Default).HasColumnName("Default");

            // Relationships
        }
    }
}