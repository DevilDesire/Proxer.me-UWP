using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Proxer.me_UWP.Base;
using Proxer.me_UWP.Views;
using ProxerMeApi.Interfaces.Values;
using Template10.Common;
using Template10.Mvvm;
using Template10.Services.NavigationService;

namespace Proxer.me_UWP.ViewModels
{
    public class AnimeDetailPageViewModel : ViewModelBase
    {
        #region Overrides

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (parameter == null)
            {
                BootStrapper.Current.NavigationService.GoBack();
            }

            Busy.SetBusy(true, "Daten werden geladen");
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                IAnimeMangaValue animeMangaValue = ProxerMeBase.AnimeHandler.GetEntry(Convert.ToInt32(parameter));
                ProxerMeBase.AnimeHandler.SetNames(animeMangaValue);
                ProxerMeBase.AnimeHandler.SetSeason(animeMangaValue);
                ProxerMeBase.AnimeHandler.SetGroups(animeMangaValue);
                ProxerMeBase.AnimeHandler.SetPublisher(animeMangaValue);
                AnimeMangaValue = animeMangaValue;
                Busy.SetBusy(false);
            }, 2000);

            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(AnimeMangaValue)] = AnimeMangaValue;
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        #endregion

        #region Methods

        #region privates
        

        #endregion

        #region publics
        
        #endregion
        
        #endregion
        #region VALUES

        #region privates

        private IAnimeMangaValue m_AnimeMangaValue;
        private SolidColorBrush m_SelectedPivotItem;
        private SolidColorBrush m_UnselectedPivotItem;

        #endregion

        #region publics

        public IAnimeMangaValue AnimeMangaValue
        {
            get { return m_AnimeMangaValue; }
            set { Set(ref m_AnimeMangaValue, value); }
        }

        public SolidColorBrush SelectedPivotItem
        {
            get { return m_SelectedPivotItem; }
            set { Set(ref m_SelectedPivotItem, value); }
        }

        public SolidColorBrush UnselectedPivotItem
        {
            get { return m_UnselectedPivotItem; }
            set { Set(ref m_UnselectedPivotItem, value); }
        }

        #endregion

        #endregion
    }
}