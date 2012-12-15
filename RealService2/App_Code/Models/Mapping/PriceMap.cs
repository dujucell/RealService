using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class PriceMap : EntityTypeConfiguration<Price>
    {
        public PriceMap()
        {
            // Primary Key
            this.HasKey(t => t.Range);

            // Properties
            this.Property(t => t.Range)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Price");
            this.Property(t => t.Range).HasColumnName("Range");
        }
    }
}
