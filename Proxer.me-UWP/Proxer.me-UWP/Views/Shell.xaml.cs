using Windows.UI.Xaml.Controls;
using Template10.Controls;
using Template10.Services.NavigationService;

namespace Proxer.me_UWP.Views
{
    public sealed partial class Shell
    {
        public static Shell Instance { get; set; }
        public static HamburgerMenu HamburgerMenu => Instance.RootHamburgerMenu;

        public Shell()
        {
            Instance = this;
            InitializeComponent();
        }

        public Shell(INavigationService navigationService) : this()
        {
            SetNavigationService(navigationService);
        }

        public void SetNavigationService(INavigationService navigationService)
        {
            RootHamburgerMenu.NavigationService = navigationService;
        }
    }
}
