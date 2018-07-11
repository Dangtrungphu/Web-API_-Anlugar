using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("HoTroTrucTuyens")]
    class HoTroTrucTuyen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }

        [Required]
        [MaxLength(50)]
        public string Ten { set; get; }

        [MaxLength(50)]
        public string BoPhan { set; get; }

        [MaxLength(50)]
        public string Skype { set; get; }

        [MaxLength(50)]
        public string DienThoai { set; get; }

        [MaxLength(50)]
        public string Email { set; get; }

        [MaxLength(50)]
        public string Yahoo { set; get; }

        [MaxLength(50)]
        public string FaceBook { set; get; }

        [MaxLength(50)]
        public string TrangThai  { set; get; }

        public int? DisplayOrder { set; get; }


    }
}
