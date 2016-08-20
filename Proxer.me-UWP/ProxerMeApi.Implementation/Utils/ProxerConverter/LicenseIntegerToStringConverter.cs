using System;
using Windows.UI.Xaml.Data;

namespace ProxerMeApi.Implementation.Utils.ProxerConverter
{
    public class LicenseIntegerToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch ((int)value)
            {
                case 1:
                    return "Nicht lizenziert";
                case 2:
                    return "lizenziert";
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