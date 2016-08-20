using System;
using Windows.UI.Xaml.Data;

namespace ProxerMeApi.Implementation.Utils.ProxerConverter
{
    public class LanguageToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            switch (value.ToString())
            {
                case "de":
                    return "/Assets/Language/german.gif";
                case "en":
                    return "/Assets/Language/english.gif";
                case "jp":
                    return "/Assets/Language/japanese.gif";
                default:
                    return "/Assets/Language/misc.gif";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}