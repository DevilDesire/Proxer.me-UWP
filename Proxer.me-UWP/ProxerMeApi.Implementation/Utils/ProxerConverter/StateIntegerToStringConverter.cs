using System;
using Windows.UI.Xaml.Data;

namespace ProxerMeApi.Implementation.Utils.ProxerConverter
{
    public class StateIntegerToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch ((int)value)
            {
                case 0:
                    return "Nicht erschienen";
                case 1:
                    return "Abgeschlossen";
                case 2:
                    return "Airing";
                default:
                    return "Unbekannt";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}