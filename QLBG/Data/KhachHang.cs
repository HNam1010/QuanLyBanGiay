using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBG.Data
{
    internal class KhachHang
    {
        public int ID { get; set; }
        public string HoTenKhachHang { get; set; }
        public int Tuoi { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
