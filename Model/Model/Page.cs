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
    [Table("Pages")]
   public class Page : Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        
        [Required]
        [MaxLength(256)]
        public string Ten { get; set; }

        [Column(TypeName ="varchar")]
        [MaxLength(256)]
        [Required]
        public string TenKhac { set; get; }

        public string NoiDung { set; get; }
    }
}
