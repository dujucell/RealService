using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class AgreementMap : EntityTypeConfiguration<Agreement>
    {
        public AgreementMap()
        {
            // Primary Key
            this.HasKey(t => t.Agreement_ID);

            // Properties
            this.Property(t => t.Agreement_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Agreement_Name)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Agreement");
            this.Property(t => t.Agreement_ID).HasColumnName("Agreement_ID");
            this.Property(t => t.Agreement_Name).HasColumnName("Agreement_Name");
        }
    }
}
