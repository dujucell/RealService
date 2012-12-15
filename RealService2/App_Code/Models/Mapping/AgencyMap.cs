using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class AgencyMap : EntityTypeConfiguration<Agency>
    {
        public AgencyMap()
        {
            // Primary Key
            this.HasKey(t => t.Agency_ID);

            // Properties
            this.Property(t => t.Agency_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Agency_Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Agency");
            this.Property(t => t.Agency_ID).HasColumnName("Agency_ID");
            this.Property(t => t.Agency_Name).HasColumnName("Agency_Name");
        }
    }
}
