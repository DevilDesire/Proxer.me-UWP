using System;
using Windows.UI.Xaml;
using DevilDesireDevLib.Interfaces;

namespace DevilDesireDevLib.Implementation.Converter
{
    public class IntToVisibilityConverter : IConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return Visibility.Collapsed;
            }

            return (int)value > 0 ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}