using Dominio.Enums;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Presentacion.Converters
{
    public class ToastToColorResourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return null;
            if (targetType.Name.Equals("Visual"))
                return ConvertVisual(value, targetType, parameter, culture);
            object result = Application.Current.TryFindResource(value.ToString());
            return result;
        }

        private object ConvertVisual(object value, Type targetType, object parameter, CultureInfo culture)
        {
            value = Enum.Parse(typeof(EToastColor),value.ToString());
            object result;
            switch (value)
            {
                case EToastColor.ErrorColor:
                    result = Application.Current.TryFindResource(EToastIcon.ErrorIcon.ToString());
                    break;
                case EToastColor.SuccessColor:
                    result = Application.Current.TryFindResource(EToastIcon.SuccessIcon.ToString());
                    break;
                case EToastColor.WarningColor:
                    result = Application.Current.TryFindResource(EToastIcon.WarningIcon.ToString());
                    break;
                default:
                    result = Application.Current.TryFindResource(EToastIcon.InfoIcon.ToString());
                    break;
            }
            return result;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
