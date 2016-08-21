using System;
using Windows.System;
using Windows.System.Profile;
using Windows.UI.Popups;
using Windows.UI.Xaml;

namespace Proxer.me_UWP.Views
{
    public sealed partial class CaptchaPage
    {
        public CaptchaPage()
        {
            InitializeComponent();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            await new MessageDialog("Es wurden zu viele Anfragen über diese IP geschickt.\r\nBitte bestätigen Sie das Captcha!").ShowAsync();

            string device = AnalyticsInfo.VersionInfo.DeviceFamily;
            WebView.Navigate(!device.Contains("Mobile")
                ? new Uri("http://proxer.me/misc/captcha?device=desktop")
                : new Uri("http://proxer.me/misc/captcha?device=mobile"));
        }
    }
}
