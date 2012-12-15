using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace RealService2.Models.Mapping
{
    public class PropertyMap : EntityTypeConfiguration<Property>
    {
        public PropertyMap()
        {
            // Primary Key
            this.HasKey(t => t.MLS_Prop_ID);

            // Properties
            this.Property(t => t.MLS_Prop_ID)
                .IsRequired()
                .HasMaxLength(25);

            this.Property(t => t.Address1)
                .HasMaxLength(50);

            this.Property(t => t.Address2)
                .HasMaxLength(50);

            this.Property(t => t.Location_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Agreement_Type)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(5);

            this.Property(t => t.Other)
                .HasMaxLength(50);

            this.Property(t => t.URL)
                .HasMaxLength(50);

            this.Property(t => t.VideoURL)
                .HasMaxLength(50);

            this.Property(t => t.Agent_ID)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Property");
            this.Property(t => t.MLS_Prop_ID).HasColumnName("MLS_Prop_ID");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.Location_ID).HasColumnName("Location_ID");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.No_Bedrooms).HasColumnName("No_Bedrooms");
            this.Property(t => t.No_Bathrooms).HasColumnName("No_Bathrooms");
            this.Property(t => t.Type).HasColumnName("Type");
            this.Property(t => t.Agreement_Type).HasColumnName("Agreement_Type");
            this.Property(t => t.Date_Posted).HasColumnName("Date_Posted");
            this.Property(t => t.Other).HasColumnName("Other");
            this.Property(t => t.URL).HasColumnName("URL");
            this.Property(t => t.VideoURL).HasColumnName("VideoURL");
            this.Property(t => t.Agent_ID).HasColumnName("Agent_ID");
            this.Property(t => t.ClientID).HasColumnName("ClientID");
            this.Property(t => t.GmapsX).HasColumnName("GmapsX");
            this.Property(t => t.GMapsY).HasColumnName("GMapsY");

            // Relationships
            this.HasRequired(t => t.Agent)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => d.Agent_ID);
            this.HasRequired(t => t.Agreement)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => d.Agreement_Type);
            this.HasOptional(t => t.Client)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => d.ClientID);
            this.HasRequired(t => t.Location)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => d.Location_ID);
            this.HasRequired(t => t.Type1)
                .WithMany(t => t.Properties)
                .HasForeignKey(d => d.Type);

        }
    }
}
