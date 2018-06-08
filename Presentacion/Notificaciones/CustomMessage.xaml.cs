using ToastNotifications.Core;

namespace Presentacion.Converters
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
    }
}
