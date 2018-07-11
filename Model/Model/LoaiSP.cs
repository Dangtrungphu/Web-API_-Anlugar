using Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("Loai_SP")]
    public class LoaiSP : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; } 
        [Required]
        public string Ten { set; get; }
        public string Tenkhac { set; get; } 
        public string Mota { get; set; }    
        public int? MaNCC { set; get; }
        public int? DisplayOrder { set; get; }  
        public int? Anh { set; get; }   

        public bool? HomeFlag { set; get; }

        public virtual IEnumerable<SanPham> SanPhams { set; get; }
    }
}
