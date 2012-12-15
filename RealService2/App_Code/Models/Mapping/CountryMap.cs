using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            // Primary Key
            this.HasKey(t => t.Country_ID);

            // Properties
            this.Property(t => t.Country_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Country_Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Country");
            this.Property(t => t.Country_ID).HasColumnName("Country_ID");
            this.Property(t => t.Country_Name).HasColumnName("Country_Name");
        }
    }
}
