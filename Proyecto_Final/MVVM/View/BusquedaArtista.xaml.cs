using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Proyecto_Final.Helpers;
using Proyecto_Final.MVVM.Models;
using Proyecto_Final.Helpers.Consumo;

namespace Proyecto_Final.MVVM.View
{
    /// <summary>
    /// Lógica de interacción para BusquedaArtista.xaml
    /// </summary>
    public partial class BusquedaArtista : UserControl
    {
        public BusquedaArtista()
        {
            Task.Run(async () => await SearchHelper.GetTokenAsync());
            InitializeComponent();
        }

        private void etesech(object sender, KeyEventArgs e)
        {
            Consumo objConsumo = new Consumo();
            objConsumo.Reduced(Artista, ListArtist);
        }
    }
}
