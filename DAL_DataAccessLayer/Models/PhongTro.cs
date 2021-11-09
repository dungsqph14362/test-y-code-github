using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("PhongTro")]
    [Index(nameof(MaHopDong), Name = "IX_PhongTro_HopDongsMaHopDong")]
    [Index(nameof(MaLoaiPhong), Name = "IX_PhongTro_LoaiPhongsMaLoaiPhong")]
    public partial class PhongTro
    {
        public PhongTro()
        {
            HinhAnhs = new HashSet<HinhAnh>();
        }

        [Key]
        public int MaPhongTro { get; set; }
        [StringLength(50)]
        public string GiaPhong { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        [StringLength(200)]
        public string MoTa { get; set; }
        [StringLength(50)]
        public string DienTich { get; set; }
        [StringLength(50)]
        public string HinhAnh { get; set; }
        public int TrangThai { get; set; }
        public int? MaLoaiPhong { get; set; }
        public int? MaHopDong { get; set; }
        [StringLength(50)]
        public string TenPhongTro { get; set; }

        [ForeignKey(nameof(MaHopDong))]
        [InverseProperty(nameof(HopDong.PhongTros))]
        public virtual HopDong MaHopDongNavigation { get; set; }
        [ForeignKey(nameof(MaLoaiPhong))]
        [InverseProperty(nameof(LoaiPhong.PhongTros))]
        public virtual LoaiPhong MaLoaiPhongNavigation { get; set; }
        [InverseProperty("MaPhongTroNavigation")]
        public virtual ICollection<HinhAnh> HinhAnhs { get; set; }
    }
}
