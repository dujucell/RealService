using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class LocationMap : EntityTypeConfiguration<Location>
    {
        public LocationMap()
        {
            // Primary Key
            this.HasKey(t => t.Location_ID);

            // Properties
            this.Property(t => t.Location_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Country_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Location");
            this.Property(t => t.Location_ID).HasColumnName("Location_ID");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Country_ID).HasColumnName("Country_ID");

            // Relationships
            this.HasRequired(t => t.Country)
                .WithMany(t => t.Locations)
                .HasForeignKey(d => d.Country_ID);

        }
    }
}
