using Aplicacion.Servicios;
using Dominio.Enums;
using Presentacion.Dto;
using System;
using System.Windows;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;

namespace Presentacion.Converters
{
    public class NotificationService : INotificationService
    {
        #region Members
        private Notifier _notifier;
        #endregion

        #region Constructor
        public NotificationService()
        {
            _notifier = new Notifier(cfg =>
            {
                cfg.PositionProvider = new WindowPositionProvider(
                    parentWindow: Application.Current.MainWindow,
                    corner: Corner.BottomRight,
                    offsetX: 0,
                    offsetY: 0);

                cfg.DisplayOptions.TopMost = false;

                cfg.LifetimeSupervisor = new TimeAndCountBasedLifetimeSupervisor(
                    notificationLifetime: TimeSpan.FromSeconds(5),
                    maximumNotificationCount: MaximumNotificationCount.FromCount(3));
            });
        }
        #endregion

        public void Notify(string title, string message, EToastColor type = EToastColor.InfoColor)
        {
            var dto = new ToastDto
            {
                Title = title,
                Message = message,
                Color = type
            };
            _notifier.Notify<CustomNotification>(() => new CustomNotification(dto));
        }
    }
}
