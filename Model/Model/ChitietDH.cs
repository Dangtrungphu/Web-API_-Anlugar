using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("ChiTietDHs")]   
    public class ChitietDH
    {
        [Key]
        public int MaDH { get; set; }

        [Key]
        public int MaSP { set; get; }

        public int SoLuong { set; get; }

        [ForeignKey("MaDH")]
        public virtual DatHang DatHang { set; get; }

        [ForeignKey("MaSP")]
        public virtual SanPham SanPham { get; set; }
    }
}
