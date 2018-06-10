using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
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
            Notification = notification;
            DataContext = notification;
            InitializeComponent();
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(250);
                Notification.Close();
            });
        }


    }
}
