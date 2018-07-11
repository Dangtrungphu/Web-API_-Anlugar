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
    [Table("BaiViets")] 
    public class BaiViet : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } 
        [Required]
        [MaxLength(256)]
        public string  Ten { set; get; }

        [Required]
        [MaxLength(256)]
        [Column(TypeName ="varchar")]
        public string Alias { set; get; }

        [Required]
        public int MaLoai { get; set; } 

        [MaxLength(256)]
        public string Anh { set; get; } 

        [MaxLength(500)]
        public string Mota { set; get; }

        public string NoiDung { set; get; }

        public bool? HomeFlag { set; get; }
        public bool? HotFlag { set; get; }
        public int? ViewCount { set; get; }

        [ForeignKey("MaLoai")]
        public virtual LoaiBaiViet LoaiBaiViet { get; set; }
    }
}
