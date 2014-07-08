using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Base_CityMap : EntityTypeConfiguration<Base_City>
    {
        public Base_CityMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.DM)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.SZSF)
                .HasMaxLength(40);

            this.Property(t => t.SZCS)
                .HasMaxLength(40);

            this.Property(t => t.SZXQ)
                .HasMaxLength(40);

            this.Property(t => t.YB)
                .HasMaxLength(10);

            this.Property(t => t.QH)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Base_City");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.DM).HasColumnName("DM");
            this.Property(t => t.SZSF).HasColumnName("SZSF");
            this.Property(t => t.SZCS).HasColumnName("SZCS");
            this.Property(t => t.SZXQ).HasColumnName("SZXQ");
            this.Property(t => t.YB).HasColumnName("YB");
            this.Property(t => t.QH).HasColumnName("QH");
        }
    }
}
