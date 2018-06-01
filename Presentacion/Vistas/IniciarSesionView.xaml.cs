using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System;
using System.Windows;
using Transversal;

namespace Presentacion.Vistas
{

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
