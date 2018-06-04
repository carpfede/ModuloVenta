namespace Transversal.Seguridad
{
    public interface IIdentificacionUsuario
    {
        int UsuarioId { get; set; }
        string UserName { get; set; }
        string Apellido { get; set; }
        string Nombre { get; set; }
        bool IsInRole(string role);

    }
}
