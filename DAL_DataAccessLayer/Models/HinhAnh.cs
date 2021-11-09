using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("HinhAnh")]
    [Index(nameof(MaPhongTro), Name = "IX_HinhAnh_PhongTrosMaPhongTro")]
    public partial class HinhAnh
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string HinhAnhPhong { get; set; }
        public int? MaPhongTro { get; set; }

        [ForeignKey(nameof(MaPhongTro))]
        [InverseProperty(nameof(PhongTro.HinhAnhs))]
        public virtual PhongTro MaPhongTroNavigation { get; set; }
    }
}
