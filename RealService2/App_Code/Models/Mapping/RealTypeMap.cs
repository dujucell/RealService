using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class RealTypeMap : EntityTypeConfiguration<RealType>
    {
        public RealTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.RealType_ID);

            // Properties
            this.Property(t => t.RealType_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.RealType_Name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Type");
            this.Property(t => t.RealType_ID).HasColumnName("Type_ID");
            this.Property(t => t.RealType_Name).HasColumnName("Type_Name");
        }
    }
}
