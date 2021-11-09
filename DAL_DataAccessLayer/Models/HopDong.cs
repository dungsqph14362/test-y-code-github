using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("HopDong")]
    [Index(nameof(MaChuTro), Name = "IX_HopDong_ChuTrosMaChuTro")]
    [Index(nameof(MaKhachHang), Name = "IX_HopDong_KhachHangsMaKhachHang")]
    public partial class HopDong
    {
        public HopDong()
        {
            HopDongChiTiets = new HashSet<HopDongChiTiet>();
            PhongTros = new HashSet<PhongTro>();
        }

        [Key]
        public int MaHopDong { get; set; }
        [StringLength(50)]
        public string TongTien { get; set; }
        public int TrangThai { get; set; }
        public int? MaChuTro { get; set; }
        public int? MaKhachHang { get; set; }

        [ForeignKey(nameof(MaChuTro))]
        [InverseProperty(nameof(ChuTro.HopDongs))]
        public virtual ChuTro MaChuTroNavigation { get; set; }
        [ForeignKey(nameof(MaKhachHang))]
        [InverseProperty(nameof(KhachHang.HopDongs))]
        public virtual KhachHang MaKhachHangNavigation { get; set; }
        [InverseProperty(nameof(HopDongChiTiet.MaHopDongNavigation))]
        public virtual ICollection<HopDongChiTiet> HopDongChiTiets { get; set; }
        [InverseProperty(nameof(PhongTro.MaHopDongNavigation))]
        public virtual ICollection<PhongTro> PhongTros { get; set; }
    }
}
