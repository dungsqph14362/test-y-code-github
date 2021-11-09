using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("ChucVu")]
    public partial class ChucVu
    {
        public ChucVu()
        {
            ChuTros = new HashSet<ChuTro>();
        }

        [Key]
        public int MaChucVu { get; set; }
        [StringLength(50)]
        public string TenChucVu { get; set; }

        [InverseProperty(nameof(ChuTro.MaChucVuNavigation))]
        public virtual ICollection<ChuTro> ChuTros { get; set; }
    }
}
