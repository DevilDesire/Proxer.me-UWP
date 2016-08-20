using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Data;

namespace ProxerMeApi.Implementation.Utils.ProxerConverter
{
    public class FskToImageListConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            string strings = value.ToString();
            string[] stringsSplitted = strings.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> images = new List<string>();

            foreach (string s in stringsSplitted)
            {
                images.Add(string.Format("/Assets/FSK/{0}.png", s));
            }

            return images;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}