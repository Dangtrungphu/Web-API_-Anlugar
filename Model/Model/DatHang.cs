using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("DatHangs")]
    public class DatHang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; } 
         
        [Required]
        [MaxLength(256)]
        public string TenKh { set; get; }
        [Required]
        [MaxLength(256)]
        public string Diachi { get; set; }

        [Required]
        [MaxLength(256)]
        public string Email { get; set; }
        [Required]
        [MaxLength(50)]
        public string DienThoai { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { get; set; }
        [Required]
        [MaxLength(256)]
        public string PhuongThucThanhToan { get; set; }
        public DateTime? NgayTao { set; get; }
        public string NguoiTao { get; set; }    
        public string TrangThaiThanhToan { get; set; }
        public bool TrangThai { get; set; }

        public virtual IEnumerable<ChiTietDH> ChiTietDHs { get; set; }

    }
}
