using System.Data.Entity.ModelConfiguration;

namespace Stolarus2.Data.Models.Mapping
{
    public class SliderMap : EntityTypeConfiguration<Slider>
    {
        public SliderMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties

            this.Property(t => t.ImageURL).HasMaxLength(255);

            this.Property(t => t.Name).HasMaxLength(255);

            this.Property(t => t.ExternalURL).HasMaxLength(255);

            this.Property(t => t.CreatedDateTime).IsRequired();

            this.Property(t => t.SeqID);

            // Table & Column Mappings

            this.ToTable("Sliders");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.ImageURL).HasColumnName("ImageURL");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ExternalURL).HasColumnName("ExternalURL");
            this.Property(t => t.CreatedDateTime).HasColumnName("CreatedDateTime");
            this.Property(t => t.SeqID).HasColumnName("SeqID");

            // Relationships
        }
    }
}