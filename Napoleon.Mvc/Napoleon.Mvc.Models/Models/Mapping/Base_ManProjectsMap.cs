using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Base_ManProjectsMap : EntityTypeConfiguration<Base_ManProjects>
    {
        public Base_ManProjectsMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.userId)
                .HasMaxLength(32);

            this.Property(t => t.notes)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Base_ManProjects");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.userId).HasColumnName("userId");
            this.Property(t => t.projectId).HasColumnName("projectId");
            this.Property(t => t.startDateTime).HasColumnName("startDateTime");
            this.Property(t => t.endDateTime).HasColumnName("endDateTime");
            this.Property(t => t.notes).HasColumnName("notes");
        }
    }
}
