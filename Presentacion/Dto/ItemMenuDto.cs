using Aplicacion.Servicios;
using Presentacion.Extensiones;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Presentacion.Dto
{
    public class ItemMenuDto : MenuItemBase, INotifyPropertyChanged
    {
        #region Members
        private string _nombre;
        private object _content;
        private ScrollBarVisibility _horizontalScrollBarVisibilityRequirement;
        private ScrollBarVisibility _verticalScrollBarVisibilityRequirement;
        private Thickness _marginRequirement = new Thickness(16);

        public new string Nombre { get => _nombre; set { this.MutateVerbose(ref _nombre, value, RaisePropertyChanged()); } }
        public new object Content { get => _content; set { this.MutateVerbose(ref _content, value, RaisePropertyChanged()); } }
        public ScrollBarVisibility HorizontalScrollBarVisibilityRequirement
        {
            get { return _horizontalScrollBarVisibilityRequirement; }
            set { this.MutateVerbose(ref _horizontalScrollBarVisibilityRequirement, value, RaisePropertyChanged()); }
        }

        public ScrollBarVisibility VerticalScrollBarVisibilityRequirement
        {
            get { return _verticalScrollBarVisibilityRequirement; }
            set { this.MutateVerbose(ref _verticalScrollBarVisibilityRequirement, value, RaisePropertyChanged()); }
        }

        public Thickness MarginRequirement
        {
            get { return _marginRequirement; }
            set { this.MutateVerbose(ref _marginRequirement, value, RaisePropertyChanged()); }
        }
        #endregion

        #region Constructores
        public ItemMenuDto(string nombre, object content)
        {
            _nombre = nombre;
            Content = content;
        }
        #endregion

        #region Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
        {
            return args => PropertyChanged?.Invoke(this, args);
        }
        #endregion
    }
}
