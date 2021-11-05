using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Key]
        [StringLength(15)]
        public string DienThoai { get; set; }
        [Required]
        [StringLength(50)]
        public string TenKhach { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        public bool? GioiTinh { get; set; }
        [Required]
        [Column("MaNV")]
        [StringLength(20)]
        public string MaNv { get; set; }

        [ForeignKey(nameof(MaNv))]
        [InverseProperty(nameof(NhanVien.KhachHangs))]
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
