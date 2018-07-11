using Model.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Model
{
    [Table("SanPhams")]
    public class SanPham
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        public string TenSP { set; get; }

        [Required]

        public string TenKhac { set; get; }        
        public int MaLoai { set; get; } 
        public string Anh { set; get; } 
        public XElement ThemAnh { get; set; }   
        public decimal GiaTien { get; set; }    
        public decimal? KhuyenMai { set; get; } 
        public int? BaoHanh { set; get; }   
        public string MoTa { set; get; }    
        public string NoiDung { set; get; } 

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("MaLoai")]
        public virtual LoaiSP LoaiSP { get; set; }

    }
}
