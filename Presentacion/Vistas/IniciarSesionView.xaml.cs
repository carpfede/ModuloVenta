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
        [Dependency]
        protected IniciarSesionPresentador _presentador { get; set; }
        

        public IniciarSesionView()
        {
            InitializeComponent();
            //_presentador = presentador;
        }

        public void AccesoPermitido(Sesion sesion)
        {
            throw new NotImplementedException();
        }

        public bool ValidName
        {
            get
            {
                return _presentador == null ? false : true;
            }
        }
    }
}
