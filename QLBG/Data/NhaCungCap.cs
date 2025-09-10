using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBG.Data
{
    internal class NhaCungCap
    {
        public int ID { get; set; }
        public string Ten_NhaCungCap { get; set; }
        public virtual ObservableCollectionListSource<Giay> Giay { get; } = new();
    }
}
