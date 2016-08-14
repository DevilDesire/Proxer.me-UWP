using Template10.Services.SerializationService;
using Windows.UI.Xaml.Navigation;


namespace Proxer.me_UWP.Views
{
    public sealed partial class SettingsPage
    {
        ISerializationService m_SerializationService;

        public SettingsPage()
        {
            this.InitializeComponent();
            m_SerializationService = SerializationService.Json;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            int index = int.Parse(m_SerializationService.Deserialize(e.Parameter?.ToString()).ToString());
            MyPivot.SelectedIndex = index;
        }
    }
}
