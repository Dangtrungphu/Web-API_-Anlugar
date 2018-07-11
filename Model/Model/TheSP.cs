using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("TheSPs")]
    class TheSP
    {
        [Key]
        public int MaSP { set; get; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string MaThe { set; get; }

        [ForeignKey("MaSP")]
        public virtual SanPham SanPham { set; get; }

        [ForeignKey("MaThe")]
        public virtual GanThe GanThe { set; get; }
    }
}

