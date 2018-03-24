using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class QuoteMap : EntityTypeConfiguration<Quote>
    {
        public QuoteMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.Author).IsRequired().HasMaxLength(255);

            this.Property(t => t.Description).HasMaxLength(1023);

            this.Property(t => t.CreatedDateTime).IsRequired();

            this.Property(t => t.SeqID);

            // Table & Column Mappings

            this.ToTable("Quotes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Author).HasColumnName("Author");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.SeqID).HasColumnName("SeqID");

            // Relationships
        }
    }
}