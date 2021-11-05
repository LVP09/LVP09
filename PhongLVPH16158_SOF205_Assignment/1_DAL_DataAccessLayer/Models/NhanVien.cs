using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace _1_DAL_DataAccessLayer.Models
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        public NhanVien()
        {
            Hangs = new HashSet<Hang>();
            KhachHangs = new HashSet<KhachHang>();
        }

        [Column("ID")]
        public int Id { get; set; }
        [Key]       
        [Column("MaNV")]
        [StringLength(20)]
        public string MaNv { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [Column("TenNV")]
        [StringLength(50)]
        public string TenNv { get; set; }
        public bool VaiTro { get; set; }
        public bool TinhTrang { get; set; }
        [Required]
        [StringLength(50)]
        public string MatKhau { get; set; }
        [Required]
        [StringLength(100)]
        public string DiaChi { get; set; }
        [Required]
        [Column("SDT")]
        [StringLength(11)]
        public string Sdt { get; set; }

        [InverseProperty(nameof(Hang.MaNvNavigation))]
        public virtual ICollection<Hang> Hangs { get; set; }
        [InverseProperty(nameof(KhachHang.MaNvNavigation))]
        public virtual ICollection<KhachHang> KhachHangs { get; set; }
    }
}
