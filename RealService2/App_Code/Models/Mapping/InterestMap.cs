using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class InterestMap : EntityTypeConfiguration<Interest>
    {
        public InterestMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Buying_Agent, t.Selling_Agent, t.Property_ID });

            // Properties
            this.Property(t => t.Buying_Agent)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Selling_Agent)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Property_ID)
                .IsRequired()
                .HasMaxLength(25);

            // Table & Column Mappings
            this.ToTable("Interests");
            this.Property(t => t.Buying_Agent).HasColumnName("Buying_Agent");
            this.Property(t => t.Selling_Agent).HasColumnName("Selling_Agent");
            this.Property(t => t.Property_ID).HasColumnName("Property_ID");

            // Relationships
            this.HasRequired(t => t.Agent)
                .WithMany(t => t.Interests)
                .HasForeignKey(d => d.Buying_Agent);
            this.HasRequired(t => t.Agent1)
                .WithMany(t => t.Interests1)
                .HasForeignKey(d => d.Selling_Agent);
            this.HasRequired(t => t.Property)
                .WithMany(t => t.Interests)
                .HasForeignKey(d => d.Property_ID);

        }
    }
}
