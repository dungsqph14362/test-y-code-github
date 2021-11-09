using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("DichVu")]
    public partial class DichVu
    {
        public DichVu()
        {
            DichVuChiTiets = new HashSet<DichVuChiTiet>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string TenDichVu { get; set; }
        [StringLength(50)]
        public string LoaiDichVu { get; set; }

        [InverseProperty(nameof(DichVuChiTiet.DichVus))]
        public virtual ICollection<DichVuChiTiet> DichVuChiTiets { get; set; }
    }
}
