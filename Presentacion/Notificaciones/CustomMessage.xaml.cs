using ToastNotifications.Core;

namespace Presentacion.Notificaciones
{
    /// <summary>
    /// Lógica de interacción para CustomMessage.xaml
    /// </summary>
    public partial class CustomMessage : NotificationDisplayPart
    {
        public CustomMessage(CustomNotification notification)
        {
            DataContext = notification;
            InitializeComponent();
        }

        public object Converter()
        {
            return new object();
        }
    }
}
