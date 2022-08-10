using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Core;



namespace Proyecto_Final.MVVM.ViewModel
{



    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }  
        public RelayCommand BusquedaArtistaCommand { get; set; }
        public RelayCommand BusquedaImagenCommand { get; set; }
        public RelayCommand BusquedaDetallesCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public BusquedaArtistaViewModel ArtistaVM { get; set; }
        public BusquedaImagenViewModel ImagenVM { get; set; }
        public BusquedaDetallesViewModel DetallesVM { get; set; }


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value;
                OnpropertyChanged();
            }
        }


        public MainViewModel()
        {
           HomeVM = new HomeViewModel();
            DetallesVM = new BusquedaDetallesViewModel();
            ArtistaVM = new BusquedaArtistaViewModel();
            ImagenVM = new BusquedaImagenViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            BusquedaArtistaCommand = new RelayCommand(o =>
            {
                 CurrentView = ArtistaVM;
            });

            BusquedaImagenCommand = new RelayCommand(o =>
            {
                CurrentView = ImagenVM;
            });

            BusquedaDetallesCommand = new RelayCommand(o =>
            {
                CurrentView = DetallesVM;
            });
        }
    }
}
