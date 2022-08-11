using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Proyecto_Final.Core       
{
    //es una clase base para objetos que son observables mediante la implementación de las interfaces  INotifyPropertyChanged
    //Notifica a los clientes que el valor de una propiedad ha cambiado.
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnpropertyChanged([CallerMemberName] string Name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));
        }
    }
}
