using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            // Primary Key
            this.HasKey(t => t.ClientID);

            // Properties
            this.Property(t => t.F_Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.L_Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.Tel)
                .HasMaxLength(15);

            this.Property(t => t.Email)
                .HasMaxLength(40);

            this.Property(t => t.Agent_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.Type)
                .IsRequired()
                .HasMaxLength(7);

            // Table & Column Mappings
            this.ToTable("Client");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.F_Name).HasColumnName("F_Name");
            this.Property(t => t.L_Name).HasColumnName("L_Name");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Agent_ID).HasColumnName("Agent_ID");
            this.Property(t => t.Type).HasColumnName("Type");

            // Relationships
            this.HasRequired(t => t.Agent)
                .WithMany(t => t.Clients)
                .HasForeignKey(d => d.Agent_ID);

        }
    }
}
