﻿using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Proxer.me_UWP.Services.SettingsServices;
using Proxer.me_UWP.Utils;
using ProxerMeApi.Implementation.Getter;
using ProxerMeApi.Implementation.Handler;
using ProxerMeApi.Implementation.Statics;
using ProxerMeApi.Interfaces.Values;
using Template10.Controls;
using Template10.Common;

namespace Proxer.me_UWP
{
    [Bindable]
    sealed partial class App : BootStrapper
    {
        public App()
        {
            InitializeComponent();
            SplashFactory = (e) => new Views.Splash(e);

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
                    Content = new Views.Shell(nav),
                    ModalContent = new Views.Busy(),
                };
            }
            await Task.CompletedTask;
        }

        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            StaticValues.ApiVersion = ApplicationKeys.ApiVersion;
            StaticValues.ApiToken = ApplicationKeys.ApiTokenKey;
            StaticValues.CookieContainer = new CookieContainer();
            IBaseValue<IUserLoginValue> loginInfo = new UserHandler().DoLogin(ApplicationKeys.Username, ApplicationKeys.Password, ApplicationKeys.ApiTokenKey);
            ApplicationKeys.UserToken = loginInfo.Data.Token;
            await Task.Delay(5000);

            NavigationService.Navigate(typeof(Views.BlankPage));
            await Task.CompletedTask;
        }
    }
}
