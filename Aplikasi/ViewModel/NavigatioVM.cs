using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikasi.Lainnya;
using System.Windows.Input;

namespace Aplikasi.ViewModel
{
    class NavigatioVM : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand HomeCommand { get; set; }
        public ICommand CustomersCommand { get; set; }
        public ICommand ProductsCommand { get; set; }
        public ICommand OrdersCommand { get; set; }
        public ICommand TransactionsCommand { get; set; }
        public ICommand ShipmentsCommand { get; set; }
        public ICommand SettingsCommand { get; set; }

        private void Home(object obj) => CurrentView = new HomeVM();
        private void Konsumen(object obj) => CurrentView = new KonsumenVM();
        private void Produk(object obj) => CurrentView = new ProdukVM();
        private void Pemesanan(object obj) => CurrentView = new PemesananVM();
        private void Transaksi(object obj) => CurrentView = new TransaksiVM();
        private void Setting(object obj) => CurrentView = new SettingVM();

        public NavigatioVM()
        {
            HomeCommand = new RelayCommand(Home);
            CustomersCommand = new RelayCommand(Konsumen);
            ProductsCommand = new RelayCommand(Produk);
            OrdersCommand = new RelayCommand(Pemesanan);
            TransactionsCommand = new RelayCommand(Transaksi);
            SettingsCommand = new RelayCommand(Setting);

            // Startup Page
            CurrentView = new HomeVM();
        }
    }
}
