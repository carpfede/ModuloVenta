namespace Aplicacion.CasosDeUso.ABM.Interfaces
{
    public interface IABM<T>
        where T : class
    {
        void Alta(T entity);
        void Baja(int id);
        void Modificacion(T entity);
    }
}
