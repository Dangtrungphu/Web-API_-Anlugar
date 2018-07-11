using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("TheBaiViets")]
    public class TheBaiViet
    {
        [Key]
        public int MaBaiViet { set; get; }

        [Key]
        [Column(TypeName ="varchar")]
        [MaxLength(50)]
        public string MaThe { set; get; }

        [ForeignKey("MaBaiViet")]
        public virtual BaiViet BaiViet { set; get; }

        [ForeignKey("MaThe")]
        public virtual GanThe GanThe { set; get; } 
    }
}
