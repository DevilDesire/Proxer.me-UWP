using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using Proxer.me_UWP.Base;
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

            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                AnimeMangaValue = ProxerMeBase.AnimeHandler.GetEntry(Convert.ToInt32(parameter));
                
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

        #region VALUES

        #region privates

        private IAnimeMangaValue m_AnimeMangaValue;

        #endregion

        #region publics

        public IAnimeMangaValue AnimeMangaValue
        {
            get { return m_AnimeMangaValue; }
            set { Set(ref m_AnimeMangaValue, value); }
        }

        #endregion

        #endregion
    }
}