using System;
using Windows.UI.Xaml.Data;
using ProxerMeApi.Interfaces.Values;

namespace Proxer.me_UWP.Utils
{
    public class NewsToNewsImageUriConverter : IValueConverter
    {
        #region Implementation
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return "";
            }

            INewsValue newsValue = (INewsValue) value;
            return string.Format("https://cdn.proxer.me/news/{0}_{1}.png", newsValue.Nid, newsValue.Image_Id);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

    public class NewsTemplateHeaderConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return "";
            }

            INewsValue newsValue = (INewsValue) value;
            return string.Format("{0} - Autor: {1} - {2} Kommentare - {3} Zugriffe", new DateTime(1970, 1, 1).AddSeconds(System.Convert.ToDouble(newsValue.Time)).ToString("dd.MM.yyyy HH:mm"), 
                                                                                     newsValue.Uname,
                                                                                     newsValue.Posts,
                                                                                     newsValue.Hits);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}