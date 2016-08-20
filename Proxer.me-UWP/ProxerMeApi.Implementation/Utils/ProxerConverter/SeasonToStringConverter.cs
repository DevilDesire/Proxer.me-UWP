using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Data;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Utils.ProxerConverter
{
    public class SeasonToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
            {
                return null;
            }
            List<IAnimeMangaSeasonValue> animeMangaSeasonValues = (List<IAnimeMangaSeasonValue>)value;
            StringBuilder stringBuilder = new StringBuilder();
            int index = 0;

            foreach (IAnimeMangaSeasonValue animeMangaSeasonValue in animeMangaSeasonValues)
            {
                switch (animeMangaSeasonValue.Season)
                {
                    case 1:
                        stringBuilder.AppendLine(string.Format("{0}: {1} {2}", index == 0 ? "Start" : "Ende", "Winter", animeMangaSeasonValue.Year));
                        break;
                    case 2:
                        stringBuilder.AppendLine(string.Format("{0}: {1} {2}", index == 0 ? "Start" : "Ende", "Frühling", animeMangaSeasonValue.Year));
                        break;
                    case 3:
                        stringBuilder.AppendLine(string.Format("{0}: {1} {2}", index == 0 ? "Start" : "Ende", "Sommer", animeMangaSeasonValue.Year));
                        break;
                    case 4:
                        stringBuilder.AppendLine(string.Format("{0}: {1} {2}", index == 0 ? "Start" : "Ende", "Herbst", animeMangaSeasonValue.Year));
                        break;
                    default:
                        stringBuilder.AppendLine("");
                        break;
                }
                index++;
            }
            string returnString = stringBuilder.ToString();
            return returnString.Remove(returnString.LastIndexOf("\r\n"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}