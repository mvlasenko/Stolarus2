using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class TranslationMap : EntityTypeConfiguration<Translation>
    {
        public TranslationMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.Code).IsRequired().HasMaxLength(255);

            this.Property(t => t.Table).IsRequired();

            this.Property(t => t.Field).IsRequired();

            this.Property(t => t.Text).HasMaxLength(4000);

            // Table & Column Mappings

            this.ToTable("Translations");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Table).HasColumnName("Table");
            this.Property(t => t.Field).HasColumnName("Field");
            this.Property(t => t.Text).HasColumnName("Text");

            // Relationships
        }
    }
}