using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class OutsideInterestMap : EntityTypeConfiguration<OutsideInterest>
    {
        public OutsideInterestMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Description)
                .HasMaxLength(300);

            this.Property(t => t.URL)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Agent_ID)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("OutsideInterests");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.URL).HasColumnName("URL");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.Agent_ID).HasColumnName("Agent_ID");

            // Relationships
            this.HasOptional(t => t.Agent)
                .WithMany(t => t.OutsideInterests)
                .HasForeignKey(d => d.Agent_ID);
            this.HasOptional(t => t.Client)
                .WithMany(t => t.OutsideInterests)
                .HasForeignKey(d => d.ClientID);

        }
    }
}
