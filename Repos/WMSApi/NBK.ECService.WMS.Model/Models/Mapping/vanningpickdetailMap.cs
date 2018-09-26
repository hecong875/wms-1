using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NBK.ECService.WMS.Model.Models.Mapping
{
    public class vanningpickdetailMap : EntityTypeConfiguration<vanningpickdetail>
    {
        public vanningpickdetailMap()
        {
            // Primary Key
            this.HasKey(t => t.SysId);

            // Table & Column Mappings
            this.ToTable("vanningpickdetail", "nbk_wms");
            this.Property(t => t.SysId).HasColumnName("SysId");
            this.Property(t => t.PickDetailSysId).HasColumnName("PickDetailSysId");
            this.Property(t => t.VanningDetailSysId).HasColumnName("VanningDetailSysId");
            this.Property(t => t.SkuSysId).HasColumnName("SkuSysId");
            this.Property(t => t.UOMSysId).HasColumnName("UOMSysId");
            this.Property(t => t.PackSysId).HasColumnName("PackSysId");
            this.Property(t => t.Loc).HasColumnName("Loc");
            this.Property(t => t.Lot).HasColumnName("Lot");
            this.Property(t => t.Lpn).HasColumnName("Lpn");
            this.Property(t => t.Qty).HasColumnName("Qty");
            this.Property(t => t.CreateBy).HasColumnName("CreateBy");
            this.Property(t => t.CreateDate).HasColumnName("CreateDate");
            this.Property(t => t.UpdateBy).HasColumnName("UpdateBy");
            this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
            this.Property(t => t.UpdateUserName).HasColumnName("UpdateUserName");
            // Relationships
            this.HasOptional(t => t.vanningdetail)
                .WithMany(t => t.vanningpickdetails)
                .HasForeignKey(d => d.VanningDetailSysId);

        }
    }
}