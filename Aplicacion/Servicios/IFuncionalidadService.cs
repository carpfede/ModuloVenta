using System.Collections.Generic;

namespace Aplicacion.Servicios
{
    public interface IFuncionalidadService
    {
        List<MenuItemBase> Funcionalidades(List<string> roles);
    }
}
