using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Template10.Common;

// Die Elementvorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=234238 dokumentiert.

namespace Proxer.me_UWP.Views
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class TestPage : Page
    {
        public TestPage()
        {
            this.InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //BootStrapper.Current.NavigationService.Navigate(typeof(AnimeDetailsPage), 894);
            BootStrapper.Current.NavigationService.Navigate(typeof(AnimeDetailsPage), 12260);
        }
    }
}
