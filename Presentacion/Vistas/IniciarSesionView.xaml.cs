using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System;
using System.Windows;
using Transversal;

namespace Presentacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para IniciarSesionView.xaml
    /// </summary>
    public partial class IniciarSesionView : Window, IIniciarSesion
    {
        private IniciarSesionPresentador _presentador;
        public IniciarSesionView()
        {
            InitializeComponent();
            _presentador = new IniciarSesionPresentador(this);
        }

        public void AccesoPermitido(Sesion sesion)
        {
            throw new NotImplementedException();
        }
    }
}
