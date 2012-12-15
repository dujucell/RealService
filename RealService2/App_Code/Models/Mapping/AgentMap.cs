using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class AgentMap : EntityTypeConfiguration<Agent>
    {
        public AgentMap()
        {
            // Primary Key
            this.HasKey(t => t.Agent_ID);

            // Properties
            this.Property(t => t.Agent_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.F_Name)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.L_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Address1)
                .HasMaxLength(50);

            this.Property(t => t.Address2)
                .HasMaxLength(50);

            this.Property(t => t.Telephone)
                .HasMaxLength(20);

            this.Property(t => t.Status)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Agency_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("Agent");
            this.Property(t => t.Agent_ID).HasColumnName("Agent_ID");
            this.Property(t => t.F_Name).HasColumnName("F_Name");
            this.Property(t => t.L_Name).HasColumnName("L_Name");
            this.Property(t => t.DOB).HasColumnName("DOB");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Telephone).HasColumnName("Telephone");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Agency_ID).HasColumnName("Agency_ID");

            // Relationships
            this.HasRequired(t => t.Agency)
                .WithMany(t => t.Agents)
                .HasForeignKey(d => d.Agency_ID);

        }
    }
}
