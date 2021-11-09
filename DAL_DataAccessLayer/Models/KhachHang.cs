using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        public KhachHang()
        {
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        public int MaKhachHang { get; set; }
        public int MaPhongTro { get; set; }
        [StringLength(50)]
        public string TenKhachHang { get; set; }
        [StringLength(50)]
        public string SoDienThoai { get; set; }
        [StringLength(100)]
        public string QueQuan { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string TienCoc { get; set; }
        [Column("CCCD")]
        [StringLength(50)]
        public string Cccd { get; set; }
        public int GioiTinh { get; set; }
        [StringLength(200)]
        public string GhiChu { get; set; }

        [InverseProperty(nameof(HopDong.MaKhachHangNavigation))]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
