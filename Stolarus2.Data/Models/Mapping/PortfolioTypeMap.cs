using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class PortfolioTypeMap : EntityTypeConfiguration<PortfolioType>
    {
        public PortfolioTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.Name).IsRequired().HasMaxLength(255);

            this.Property(t => t.CreatedDateTime).IsRequired();

            this.Property(t => t.SeqID);

            // Table & Column Mappings

            this.ToTable("PortfolioTypes");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.SeqID).HasColumnName("SeqID");

            // Relationships
            this.HasMany(e => e.Portfolios)
                .WithOptional(e => e.PortfolioType)
                .WillCascadeOnDelete(false);

        }
    }
}