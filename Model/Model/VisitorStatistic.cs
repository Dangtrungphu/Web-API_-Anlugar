using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    [Table("VisitorStatistics")]
    class VisitorStatistic
    {
        [Key]
        public Guid guid { set; get; }

        [Required]
        public DateTime VisiteaDate { set; get; }

        [MaxLength (50)]
        public string IPAddress { set; get; }
    }
}
