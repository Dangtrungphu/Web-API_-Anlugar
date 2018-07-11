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
    [Table("LoaiBaiViet")]
    public class LoaiBaiViet : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string TenLoai { set; get; }

        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        public string Alias { set; get; }

        [MaxLength (500)]
        public string MoTa { set; get; }

        public int? MaNCC { set; get; }
        public int? DisplayOrder { set; get; }  
         
        [MaxLength(256)]
        public string Anh { set; get; }

        public bool HomeFlag { set; get; }

        public virtual IEnumerable<BaiViet> BaiViets { set; get; }
    }
}
