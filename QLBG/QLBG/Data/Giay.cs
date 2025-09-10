using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBG.Data
{
    internal class Giay
    {
        public int ID { get; set; }
        public int LoaiGiayID { get; set; }
        public int NhaCungCapID { get; set; }
        public string TenGiay { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int Size { get; set; }       

        public virtual ObservableCollectionListSource<ChiTiet_HoaDon> ChiTiet_HoaDon { get; } = new();
        public virtual LoaiGiay LoaiGiay { get; set; } = null!;
        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
    }

    internal class DanhSachGiay
    {
        public int ID { get; set; }
        public int LoaiGiayID { get; set; }
        public string Ten_LoaiGiay { get; set; }
        public int NhaCungCapID { get; set; }
        public string Ten_NhaCungCap { get; set; }
        public string TenGiay { get; set; }
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public int Size { get; set; }       

        public virtual ObservableCollectionListSource<ChiTiet_HoaDon> ChiTiet_HoaDon { get; } = new();
        public virtual LoaiGiay LoaiGiay { get; set; } = null!;
        public virtual NhaCungCap NhaCungCap { get; set; } = null!;
    }
}
