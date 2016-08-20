using System;
using Windows.UI.Xaml.Data;

namespace ProxerMeApi.Implementation.Utils.ProxerConverter
{
    public class CommentStateIntegerToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch ((int)value)
            {
                case 0:
                    return "geschaut";
                case 1:
                    return "am schauen";
                case 2:
                    return "wird geschaut";
                case 3:
                    return "abgebrochen";
                default:
                    return "unbekannt";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}