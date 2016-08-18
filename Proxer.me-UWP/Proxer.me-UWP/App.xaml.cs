using System;
using System.Net;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Proxer.me_UWP.Services.SettingsServices;
using Proxer.me_UWP.Utils;
using Proxer.me_UWP.Views;
using ProxerMeApi.Implementation.Handler;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Interfaces.Values;
using Template10.Common;
using Template10.Controls;

namespace Proxer.me_UWP
{
    [Bindable]
    sealed partial class App : BootStrapper
    {
        public App()
        {
            InitializeComponent();
            SplashFactory = (e) => new Splash(e);

            #region App settings

            SettingsService settings = SettingsService.Instance;
            RequestedTheme = settings.AppTheme;
            CacheMaxDuration = settings.CacheMaxDuration;
            ShowShellBackButton = settings.UseShellBackButton;

            #endregion
        }

        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            if (Window.Current.Content as ModalDialog == null)
            {
                // create a new frame 
                var nav = NavigationServiceFactory(BackButton.Attach, ExistingContent.Include);

                // create modal root
                Window.Current.Content = new ModalDialog
                {
                    DisableBackButtonWhenModal = true,
                    Content = new Shell(nav),
                    ModalContent = new Busy(),
                };
            }
            await Task.CompletedTask;
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                await StatusBar.GetForCurrentView().HideAsync();
            }
            StaticValues.ApiVersion = ApplicationKeys.ApiVersion;
            StaticValues.ApiToken = ApplicationKeys.ApiTokenKey;
            StaticValues.CookieContainer = new CookieContainer();
            int retryCount = 3;

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    IBaseValue<IUserLoginValue> loginInfo = new UserHandler().DoLogin(ApplicationKeys.Username, ApplicationKeys.Password, ApplicationKeys.ApiTokenKey);
                    ApplicationKeys.UserToken = loginInfo.Data.Token;
                    StaticValues.UserId = loginInfo.Data.Uid;
                }
                catch (Exception ex)
                {
                    if (i < retryCount)
                    {
                        continue;
                    }

                    await new MessageDialog(ex.Message, "Problem festgestellt").ShowAsync();
                }
            }


            await Task.Delay(5000);

            NavigationService.Navigate(typeof(BlankPage));
            await Task.CompletedTask;
        }
    }
}
