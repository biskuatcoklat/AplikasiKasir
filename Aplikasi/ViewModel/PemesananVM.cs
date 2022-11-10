using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikasi.Model;

namespace Aplikasi.ViewModel
{
    class PemesananVM:Lainnya.ViewModelBase
    {
        private readonly HalamanModel halamanModel;
        public DateTime PemesananTime
        {
            get { return halamanModel.Pemesanan; }
            set { halamanModel. Pemesanan = value; OnPropertyChanged(); }
        }

        public PemesananVM()
        {
            halamanModel = new HalamanModel();
            PemesananTime = DateTime.Now;
        }
    }
}
