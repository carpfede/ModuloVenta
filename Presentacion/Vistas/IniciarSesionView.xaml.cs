using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System;
using System.Windows;
using Transversal;
using Unity.Attributes;

namespace Presentacion.Vistas
{
    /// <summary>
    /// Lógica de interacción para IniciarSesionView.xaml
    /// </summary>
    public partial class IniciarSesionView : Window, IIniciarSesion
    {
        private IniciarSesionPresentador _presentador;

        public IniciarSesionView(IniciarSesionPresentador presentador)
        {
            _presentador = presentador;
            _presentador.SetView(this);
            InitializeComponent();
        }

        public void AccesoPermitido(Sesion sesion)
        {
            throw new NotImplementedException();
        }
    }
}
