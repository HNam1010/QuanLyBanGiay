using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBG.Data
{
    internal class LoaiGiay
    {
        public int ID { get; set; }
        public string Ten_LoaiGiay { get; set; }
        public virtual ObservableCollectionListSource<Giay> Giay { get; } = new();
    }
}
