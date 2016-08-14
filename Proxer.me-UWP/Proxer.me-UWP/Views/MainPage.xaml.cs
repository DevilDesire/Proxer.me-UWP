using Windows.UI.Xaml.Controls;
using Proxer.me_UWP.Utils;
using ProxerMeApi.Implementation.Handler;
using ProxerMeApi.Interfaces.Handler;

// Die Vorlage "Leere Seite" ist unter http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 dokumentiert.

namespace Proxer.me_UWP.Views
{
    /// <summary>
    /// Eine leere Seite, die eigenständig verwendet oder zu der innerhalb eines Rahmens navigiert werden kann.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            IUserHandler UserHandler = new UserHandler();
            UserHandler.DoLogin(ApplicationKeys.Username, ApplicationKeys.Password);
        }
    }
}
