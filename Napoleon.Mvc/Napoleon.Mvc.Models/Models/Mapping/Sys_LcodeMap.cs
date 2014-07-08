using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Sys_LcodeMap : EntityTypeConfiguration<Sys_Lcode>
    {
        public Sys_LcodeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.listCode)
                .HasMaxLength(32);

            this.Property(t => t.listName)
                .HasMaxLength(32);

            this.Property(t => t.picAddress)
                .HasMaxLength(128);

            this.Property(t => t.linkAddress)
                .HasMaxLength(128);

            this.Property(t => t.linkLevel)
                .HasMaxLength(32);

            this.Property(t => t.parentID)
                .HasMaxLength(32);

            this.Property(t => t.depth)
                .HasMaxLength(64);

            // Table & Column Mappings
            this.ToTable("Sys_Lcode");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.listCode).HasColumnName("listCode");
            this.Property(t => t.listName).HasColumnName("listName");
            this.Property(t => t.picAddress).HasColumnName("picAddress");
            this.Property(t => t.linkAddress).HasColumnName("linkAddress");
            this.Property(t => t.linkLevel).HasColumnName("linkLevel");
            this.Property(t => t.parentID).HasColumnName("parentID");
            this.Property(t => t.depth).HasColumnName("depth");
            this.Property(t => t.flag).HasColumnName("flag");
        }
    }
}
