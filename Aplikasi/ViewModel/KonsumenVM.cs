using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikasi.Model;

namespace Aplikasi.ViewModel
{
    class KonsumenVM:Lainnya.ViewModelBase
    {
        private readonly HalamanModel halamanModel;
        public int KonsumenID
        {
            get { return halamanModel.PelangganCount; }
            set { halamanModel.PelangganCount = value; OnPropertyChanged(); }
        }

        public KonsumenVM()
        {
            halamanModel = new HalamanModel();
            KonsumenID = 100528;
        }
    }
}
