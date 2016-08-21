using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Proxer.me_UWP.Base;
using Proxer.me_UWP.Views;
using ProxerMeApi.Implementation.SpezifischeExceptions;
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

            ActivateBusy();
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                try
                {
                    IAnimeMangaValue animeMangaValue = ProxerMeBase.AnimeHandler.GetEntry(Convert.ToInt32(parameter));
                    ProxerMeBase.AnimeHandler.SetNames(animeMangaValue);
                    ProxerMeBase.AnimeHandler.SetSeason(animeMangaValue);
                    ProxerMeBase.AnimeHandler.SetGroups(animeMangaValue);
                    ProxerMeBase.AnimeHandler.SetPublisher(animeMangaValue);
                    AnimeMangaValue = animeMangaValue;
                    DeactiveBusy();
                }
                catch (CaptchaException ex)
                {
                    DeactiveBusy();
                    BootStrapper.Current.NavigationService.Navigate(typeof(CaptchaPage), ex.Message);
                }
                
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

        private void LoadAnimeMangaEpisodes()
        {
            if (AnimeMangaListInfoValue != null)
            {
                return;
            }

            ActivateBusy();
            try
            {
                AnimeMangaListInfoValue = ProxerMeBase.AnimeHandler.GetEpisodes(AnimeMangaValue.Id);
                DeactiveBusy();
            }
            catch (CaptchaException ex)
            {
                DeactiveBusy();
                BootStrapper.Current.NavigationService.Navigate(typeof(CaptchaPage), ex.Message);
            }
        }

        private void LoadAnimeMangaKommentare()
        {
            if (AnimeMangaKommentarValues != null)
            {
                return;
            }

            ActivateBusy();
            try
            {
                AnimeMangaKommentarValues = ProxerMeBase.AnimeHandler.GetComments(AnimeMangaValue.Id);
                DeactiveBusy();
            }
            catch (CaptchaException ex)
            {
                DeactiveBusy();
                BootStrapper.Current.NavigationService.Navigate(typeof(CaptchaPage), ex.Message);
            }
        }

        private void ActivateBusy()
        {
            Busy.SetBusy(true, "Daten werden geladen");
        }

        private void DeactiveBusy()
        {
            Busy.SetBusy(false);
        }

        private void LoadNewValues(int index)
        {
            switch (index)
            {
                case 1:
                    LoadAnimeMangaEpisodes();
                    break;
                case 2:
                    //Verbindungen
                    break;
                case 3:
                    //Updates
                    break;
                case 4:
                    LoadAnimeMangaKommentare();
                    break;
            }
        }

        #endregion

        #region publics

        #endregion

        #endregion
        #region VALUES

        #region privates

        private IAnimeMangaValue m_AnimeMangaValue;
        private SolidColorBrush m_SelectedPivotItem;
        private SolidColorBrush m_UnselectedPivotItem;
        private int? m_PivotIndex;
        private IAnimeMangaListInfoValue<IEpisodeValue> m_AnimeMangaListInfoValue;
        private List<IAnimeMangaKommentarValue> m_AnimeMangaKommentarValues;

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

        public int PivotIndex
        {
            get { return m_PivotIndex ?? 0; }
            set
            {
                Set(ref m_PivotIndex, value);
                LoadNewValues(value);
            }
        }

        public IAnimeMangaListInfoValue<IEpisodeValue> AnimeMangaListInfoValue
        {
            get { return m_AnimeMangaListInfoValue; }
            set { Set(ref m_AnimeMangaListInfoValue, value); }
        }

        public List<IEpisodeValue> GerSub
        {
            get { return AnimeMangaListInfoValue.Episodes.Where(x => x.Typ == "gersub").ToList(); }
        }

        public List<IEpisodeValue> EngSub
        {
            get { return AnimeMangaListInfoValue.Episodes.Where(x => x.Typ == "engsub").ToList(); }
        }

        public List<IEpisodeValue> GerDub
        {
            get { return AnimeMangaListInfoValue.Episodes.Where(x => x.Typ == "gerdub").ToList(); }
        }

        public List<IEpisodeValue> EngDub
        {
            get { return AnimeMangaListInfoValue.Episodes.Where(x => x.Typ == "engdub").ToList(); }
        }

        public int GerSubCount
        {
            get { return AnimeMangaListInfoValue.Episodes.Count(x => x.Typ == "gersub"); }
        }

        public int EngSubCount
        {
            get { return AnimeMangaListInfoValue.Episodes.Count(x => x.Typ == "engsub"); }
        }

        public int GerDubCount
        {
            get { return AnimeMangaListInfoValue.Episodes.Count(x => x.Typ == "gerdub"); }
        }

        public int EngDubCount
        {
            get { return AnimeMangaListInfoValue.Episodes.Count(x => x.Typ == "engdub"); }
        }

        public List<IAnimeMangaKommentarValue> AnimeMangaKommentarValues
        {
            get { return m_AnimeMangaKommentarValues; }
            set { Set(ref m_AnimeMangaKommentarValues, value); }
        } 

        #endregion

        #endregion

        #region DelegateCommands

        #region privates



        #endregion

        #region public



        #endregion

        #endregion
    }
}