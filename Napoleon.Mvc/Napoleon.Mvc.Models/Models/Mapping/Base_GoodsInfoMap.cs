using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Napoleon.Mvc.Models.Models.Mapping
{
    public class Base_GoodsInfoMap : EntityTypeConfiguration<Base_GoodsInfo>
    {
        public Base_GoodsInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.goodsName)
                .HasMaxLength(128);

            this.Property(t => t.notes)
                .HasMaxLength(256);

            // Table & Column Mappings
            this.ToTable("Base_GoodsInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.goodsName).HasColumnName("goodsName");
            this.Property(t => t.goodsPrices).HasColumnName("goodsPrices");
            this.Property(t => t.buyDateTime).HasColumnName("buyDateTime");
            this.Property(t => t.buyNumber).HasColumnName("buyNumber");
            this.Property(t => t.stockNumber).HasColumnName("stockNumber");
            this.Property(t => t.notes).HasColumnName("notes");
        }
    }
}
