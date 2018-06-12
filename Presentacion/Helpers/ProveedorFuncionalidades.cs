using Aplicacion.Servicios;
using Presentacion.Dto;
using System.Collections.Generic;
using System.Windows.Controls;

namespace Presentacion.Helpers
{
    public class ProveedorFuncionalidades : IFuncionalidadService
    {
        public List<MenuItemBase> Funcionalidades(List<string> roles)
        {
            List<MenuItemBase> items = new List<MenuItemBase>();
            if (roles.Contains("Administrador"))
            {
                items.AddRange(
                    new ItemMenuDto[]
                    {
                        new ItemMenuDto("Nuevo Usuario", "Usuarios", new UserControl{ }),
                        new ItemMenuDto("Nuevo Empleado", "Empleados", new UserControl{ }),
                        new ItemMenuDto("Nuevo Notificacion", "Notificaciones", new UserControl{ }),
                        new ItemMenuDto("Nuevo Mensaje", "Mensajería", new UserControl{ }),
                    });
            }
            return items;
        }
    }
}
