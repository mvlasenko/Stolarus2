using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class PortfolioMap : EntityTypeConfiguration<Portfolio>
    {
        public PortfolioMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.PortfolioTypeId);

            this.Property(t => t.Name).IsRequired().HasMaxLength(255);

            this.Property(t => t.Description).HasMaxLength(1023);

            this.Property(t => t.ImageURL).HasMaxLength(255);

            this.Property(t => t.CreatedDateTime).IsRequired();

            this.Property(t => t.SeqID);

            // Table & Column Mappings

            this.ToTable("Portfolios");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PortfolioTypeId).HasColumnName("PortfolioTypeId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ImageURL).HasColumnName("ImageURL");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.SeqID).HasColumnName("SeqID");

            // Relationships
            this.HasOptional(t => t.PortfolioType)
                .WithMany(t => t.Portfolios)
                .HasForeignKey(d => d.PortfolioTypeId);

            this.HasMany(e => e.PortfolioDetails)
                .WithOptional(e => e.Portfolio)
                .WillCascadeOnDelete(false);

        }
    }
}