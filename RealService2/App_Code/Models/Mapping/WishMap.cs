using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class WishMap : EntityTypeConfiguration<Wish>
    {
        public WishMap()
        {
            // Primary Key
            this.HasKey(t => t.Wish_ID);

            // Properties
            this.Property(t => t.Location_ID)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Type)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Agreement_Type)
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Agent_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Wish");
            this.Property(t => t.Wish_ID).HasColumnName("Wish_ID");
            this.Property(t => t.Location_ID).HasColumnName("Location_ID");
            this.Property(t => t.No_Bedrooms).HasColumnName("No_Bedrooms");
            this.Property(t => t.No_Bathrooms).HasColumnName("No_Bathrooms");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Agreement_Type).HasColumnName("Agreement_Type");
            this.Property(t => t.Agent_ID).HasColumnName("Agent_ID");
            this.Property(t => t.Client_ID).HasColumnName("Client_ID");

            // Relationships
            this.HasRequired(t => t.Agent)
                .WithMany(t => t.Wishes)
                .HasForeignKey(d => d.Agent_ID);
            this.HasOptional(t => t.Client)
                .WithMany(t => t.Wishes)
                .HasForeignKey(d => d.Client_ID);

        }
    }
}
