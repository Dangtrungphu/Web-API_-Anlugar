using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Abstract
{
    public interface IAuditable
    {
        DateTime? NgayNhap { get; set; }
        string NguoiNhap { get; set; }
        DateTime? NgayCapNhat { set; get; }
        string NguoiCapNhat { set; get; }

        string TuKhoa { get; set; }
        string MoTa { get; set; }

        bool TrangThai { get; set; }
    }
}
