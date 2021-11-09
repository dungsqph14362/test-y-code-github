using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("DichVuChiTiet")]
    [Index(nameof(DichVusId), Name = "IX_DichVuChiTiet_DichVusId")]
    public partial class DichVuChiTiet
    {
        public DichVuChiTiet()
        {
            HopDongChiTiets = new HashSet<HopDongChiTiet>();
        }

        [Key]
        public int Id { get; set; }
        public int ChiSoCu { get; set; }
        public int ChiSoMoi { get; set; }
        [StringLength(50)]
        public string DonGia { get; set; }
        public int? DichVusId { get; set; }

        [ForeignKey(nameof(DichVusId))]
        [InverseProperty(nameof(DichVu.DichVuChiTiets))]
        public virtual DichVu DichVus { get; set; }
        [InverseProperty(nameof(HopDongChiTiet.DichVuChiTiets))]
        public virtual ICollection<HopDongChiTiet> HopDongChiTiets { get; set; }
    }
}
