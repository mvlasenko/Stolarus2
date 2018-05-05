using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class PortfolioDetailMap : EntityTypeConfiguration<PortfolioDetail>
    {
        public PortfolioDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.PortfolioId);

            this.Property(t => t.Name).IsRequired().HasMaxLength(255);

            this.Property(t => t.ImageID).HasMaxLength(255);

            this.Property(t => t.CreatedDateTime).IsRequired();

            this.Property(t => t.SeqID);

            // Table & Column Mappings

            this.ToTable("PortfolioDetails");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PortfolioId).HasColumnName("PortfolioId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ImageID).HasColumnName("ImageID");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.SeqID).HasColumnName("SeqID");

            // Relationships
            this.HasRequired(t => t.Portfolio)
                .WithMany(t => t.PortfolioDetails)
                .HasForeignKey(d => d.PortfolioId);

        }
    }
}