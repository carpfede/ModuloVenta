using Dominio.Dto;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ToastNotifications.Core;

namespace Presentacion.Notificaciones
{
    public class CustomNotification : NotificationBase, INotifyPropertyChanged
    {
        #region Members
        private CustomMessage _customMessage;
        public override NotificationDisplayPart DisplayPart => _customMessage ?? (_customMessage = new CustomMessage(this));

        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }
        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                OnPropertyChanged();
            }
        }
        #endregion


        public CustomNotification(ToastDto dto)
        {
            Title = dto.Title;
            Message = dto.Message;
            Color = dto.Color.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
                handler.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
