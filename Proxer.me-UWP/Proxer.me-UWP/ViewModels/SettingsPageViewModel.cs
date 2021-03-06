﻿using System;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.UI.Xaml;
using Template10.Mvvm;

namespace Proxer.me_UWP.ViewModels
{
    public class SettingsPageViewModel : ViewModelBase
    {
        public SettingsPartViewModel SettingsPartViewModel { get; } = new SettingsPartViewModel();
        public AboutPartViewModel AboutPartViewModel {get;} = new AboutPartViewModel();
    }

    public class SettingsPartViewModel : ViewModelBase
    {
        Services.SettingsServices.SettingsService m_Settings;

        public SettingsPartViewModel()
        {
            if (DesignMode.DesignModeEnabled)
            {
                // designtime
            }
            else
            {
                m_Settings = Services.SettingsServices.SettingsService.Instance;
            }
        }

        public bool UseShellBackButton
        {
            get { return m_Settings.UseShellBackButton; }
            set { m_Settings.UseShellBackButton = value; RaisePropertyChanged(); }
        }

        public bool UseLightThemeButton
        {
            get { return m_Settings.AppTheme.Equals(ApplicationTheme.Light); }
            set { m_Settings.AppTheme = value ? ApplicationTheme.Light : ApplicationTheme.Dark; RaisePropertyChanged(); }
        }

        private string m_BusyText = "Please wait...";
        public string BusyText
        {
            get { return m_BusyText; }
            set
            {
                Set(ref m_BusyText, value);
                m_ShowBusyCommand.RaiseCanExecuteChanged();
            }
        }

        DelegateCommand m_ShowBusyCommand;
        public DelegateCommand ShowBusyCommand
            => m_ShowBusyCommand ?? (m_ShowBusyCommand = new DelegateCommand(async () =>
            {
                Views.Busy.SetBusy(true, m_BusyText);
                await Task.Delay(5000);
                Views.Busy.SetBusy(false);
            }, () => !string.IsNullOrEmpty(BusyText)));
    }

    public class AboutPartViewModel : ViewModelBase
    {
        public Uri Logo => Package.Current.Logo;

        public string DisplayName => Package.Current.DisplayName;
        public string Publisher => Package.Current.PublisherDisplayName;

        public string Version
        {
            get
            {
                PackageVersion version = Package.Current.Id.Version;
                return string.Format("{0}.{1}.{2}.{3}", version.Major, version.Minor, version.Build, version.Revision);
            }
        }

        public Uri RateMe => new Uri("http://proxer.me");
    }
}