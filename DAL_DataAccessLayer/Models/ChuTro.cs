using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("ChuTro")]
    [Index(nameof(MaChucVu), Name = "IX_ChuTro_ChucVusMaChucVu")]
    public partial class ChuTro
    {
        public ChuTro()
        {
            HopDongs = new HashSet<HopDong>();
        }

        [Key]
        public int MaChuTro { get; set; }
        [StringLength(50)]
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        [Column("SDT")]
        [StringLength(50)]
        public string Sdt { get; set; }
        [StringLength(100)]
        public string DiaChi { get; set; }
        [StringLength(50)]
        public string NamSinh { get; set; }
        public int TrangThai { get; set; }
        public int ChucVu { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string MatKhau { get; set; }
        public int? MaChucVu { get; set; }
        [Column("flag")]
        public bool? Flag { get; set; }

        [ForeignKey(nameof(MaChucVu))]
        [InverseProperty("ChuTros")]
        public virtual ChucVu MaChucVuNavigation { get; set; }
        [InverseProperty(nameof(HopDong.MaChuTroNavigation))]
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
