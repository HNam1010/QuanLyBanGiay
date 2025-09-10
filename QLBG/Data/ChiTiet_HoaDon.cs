using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBG.Data
{
    internal class ChiTiet_HoaDon
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int GiayID { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual Giay Giay { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachHoaDon_ChiTiet
    {
        public int ID { get; set; }
        public int HoaDonID { get; set; }
        public int GiayID { get; set; }
        public string TenGiay { get; set; } // Thêm
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public int ThanhTien { get; set; } // Thêm
    }
}
