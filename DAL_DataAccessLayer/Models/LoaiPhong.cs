using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace DAL_DataAccessLayer.Models
{
    [Table("LoaiPhong")]
    public partial class LoaiPhong
    {
        public LoaiPhong()
        {
            PhongTros = new HashSet<PhongTro>();
        }

        [Key]
        public int MaLoaiPhong { get; set; }
        [StringLength(50)]
        public string TenLoaiPhong { get; set; }

        [InverseProperty(nameof(PhongTro.MaLoaiPhongNavigation))]
        public virtual ICollection<PhongTro> PhongTros { get; set; }
    }
}
