using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public DateTime? NgayNhap { get; set; }
        [MaxLength(256)]
        public string NguoiNhap { get; set; }
        public DateTime? NgayCapNhat { set; get; }
        [MaxLength(256)]
        public string NguoiCapNhat { set; get; }

        [MaxLength(256)]
        public string TuKhoa { get; set; }
        [MaxLength(256)]
        public string MoTa { get; set; }
        
        public bool TrangThai { get; set; }
    }
}
