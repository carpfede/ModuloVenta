﻿using Presentacion.Interfaces;
using Presentacion.Presentadores;
using System;
using System.Windows;
using Transversal.IoC;

namespace Presentacion.Vistas
{

    public partial class IniciarSesionView : Window, IIniciarSesion
    {
        #region Members
        private IniciarSesionPresentador _presentador;
        #endregion

        #region Constructor
        public IniciarSesionView(IniciarSesionPresentador presentador)
        {
            _presentador = presentador;
            _presentador.SetView(this);
            DataContext = this;
            InitializeComponent();
        }
        #endregion

        #region IIniciarSesion Methods 
        public string Usuario => txtUsuario.Text;
        public string Contraseña => txtPass.Password;
        public void AccesoPermitido()
        {
            Hide();
            var view = (MenuPrincipalView)IoCFactory.Instance.CurrentContainer.Resolve<IMenuPrincipal>();
            view.Show();
        }
        #endregion

        #region Private Methods
        private void BtnMinimize(object sender, EventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnClose(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnIngresar(object sender, EventArgs e)
        {
            _presentador.IngresarAlSistema();
        }
        #endregion
    }
}
