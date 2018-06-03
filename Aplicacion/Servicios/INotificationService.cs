using Dominio.Enums;

namespace Aplicacion.Servicios
{
    public interface INotificationService
    {
        void Notify(string title, string message, EToastColor type = EToastColor.InfoColor);

    }
}
