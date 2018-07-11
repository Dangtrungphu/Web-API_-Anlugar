using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("Thes")]
    public class The
    {
        [Key]
        [MaxLength(50)]
        public string ID { set; get; }

        [MaxLength(50)]
        [Required]
        public string Ten { set; get; }

        [MaxLength(50)]
        [Required]
        public string Type { set; get; }

    }
}
