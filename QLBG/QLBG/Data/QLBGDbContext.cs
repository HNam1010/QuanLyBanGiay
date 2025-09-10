using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBG.Data
{
    internal class QLBGDbContext : DbContext
    {
        public DbSet<LoaiGiay> LoaiGiay { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<Giay> Giay { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTiet_HoaDon> ChiTiet_HoaDon { get; set; }
        private string connectionString = "Server=.\\SQLEXPRESS;Database=QLBG;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(connectionString);
    }
}
