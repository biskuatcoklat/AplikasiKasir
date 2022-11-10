using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi.Model
{
    public class HalamanModel
    {
        public int PelangganCount { get; set; }
        public string ProdukStatus { get; set; }
        public decimal TransaksiValue { get; set; }
        public DateTime Pemesanan { get; set; }
        public bool LokasiCek { get; set; }

    }
}
