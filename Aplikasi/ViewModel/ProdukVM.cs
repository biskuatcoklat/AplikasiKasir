using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikasi.Model;

namespace Aplikasi.ViewModel
{
    class ProdukVM : Lainnya.ViewModelBase
    {
        private readonly HalamanModel halamanModel;
        public string ProductAvailability
        {
            get { return halamanModel.ProdukStatus; }
            set { halamanModel.ProdukStatus = value; OnPropertyChanged(); }
        }

        public ProdukVM()
        {
            halamanModel = new HalamanModel();
            ProductAvailability = "Nggk ada Stock Barang cuy";
        }
    }
}
