using System;
using System.Text;
using Windows.UI.Xaml.Data;

namespace ProxerMeApi.Implementation.Utils.ProxerConverter
{
    public class CommentToHtmlConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return "";
            }

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("<!DOCTYPE html>");
            stringBuilder.AppendLine("<html lang=\"de\">");
            stringBuilder.AppendLine("  <head>");
            stringBuilder.AppendLine("    <meta charset=\"utf - 8\">");
            stringBuilder.AppendLine("    <meta name=\"viewport\" content=\"width = device - width, initial - scale = 1.0\" > ");
            stringBuilder.AppendLine("    <title>Titel</title>");
            stringBuilder.AppendLine("  </head>");
            stringBuilder.AppendLine("  <body>");
            stringBuilder.AppendLine(value.ToString());
            stringBuilder.AppendLine("  </body>");
            stringBuilder.AppendLine("</html>");

            return stringBuilder.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}