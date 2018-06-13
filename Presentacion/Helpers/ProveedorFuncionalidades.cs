using Aplicacion.Servicios;
using Presentacion.ControlesDeUsuario;
using Presentacion.Dto;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Presentacion.Helpers
{
    public class ProveedorFuncionalidades : IFuncionalidadService
    {
        public List<MenuItemBase> Funcionalidades(List<string> roles)
        {
            List<MenuItemBase> items = new List<MenuItemBase>
            {
                new ItemMenuDto("Inicio", "", new Home())
            };
            if (roles.Contains("Administrador"))
            {
                items.AddRange(
                    new ItemMenuDto[]
                    {
                        new ItemMenuDto("Nuevo Usuario", "Usuarios", new UsuariosIndexControl(new List<Dominio.Entidades.Usuario>())),
                        new ItemMenuDto("Nuevo Empleado", "Empleados", new UserControl{ }),
                        new ItemMenuDto("Nuevo Notificacion", "Notificaciones", new UserControl{ }),
                        new ItemMenuDto("Nuevo Mensaje", "Mensajería", new UserControl{ }),
                    });
            }
            return items;
        }
    }
}
