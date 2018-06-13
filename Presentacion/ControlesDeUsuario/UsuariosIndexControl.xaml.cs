using Dominio.Entidades;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Windows.Controls;

namespace Presentacion.ControlesDeUsuario
{
    [PrincipalPermission(SecurityAction.Demand, Role = "Administrador")]
    public partial class UsuariosIndexControl : UserControl
    {
        public List<Usuario> Lista { get; }
        public UsuariosIndexControl(List<Usuario> usuarios)
        {
            Lista = usuarios;
            DataContext = this;
            InitializeComponent();
        }
    }
}
