using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("HopDongChiTiet")]
    [Index(nameof(DichVuChiTietsId), Name = "IX_HopDongChiTiet_DichVuChiTietsId")]
    [Index(nameof(MaHopDong), Name = "IX_HopDongChiTiet_HopDongsMaHopDong")]
    public partial class HopDongChiTiet
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string TienDien { get; set; }
        [StringLength(50)]
        public string TienNuoc { get; set; }
        [StringLength(50)]
        public string TienPhong { get; set; }
        [StringLength(50)]
        public string TienMang { get; set; }
        [StringLength(50)]
        public string TienVeSinh { get; set; }
        [StringLength(200)]
        public string GhiChu { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayXuat { get; set; }
        public int? DichVuChiTietsId { get; set; }
        public int? MaHopDong { get; set; }

        [ForeignKey(nameof(DichVuChiTietsId))]
        [InverseProperty(nameof(DichVuChiTiet.HopDongChiTiets))]
        public virtual DichVuChiTiet DichVuChiTiets { get; set; }
        [ForeignKey(nameof(MaHopDong))]
        [InverseProperty(nameof(HopDong.HopDongChiTiets))]
        public virtual HopDong MaHopDongNavigation { get; set; }
    }
}
