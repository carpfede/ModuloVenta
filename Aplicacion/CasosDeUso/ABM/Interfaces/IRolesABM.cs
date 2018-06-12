using Dominio.Entidades;

namespace Aplicacion.CasosDeUso.ABM.Interfaces
{
    public interface IRolesABM : IABM<Rol>
    {
        Rol ObtenerPorNombre(string nombre);
    }
}
