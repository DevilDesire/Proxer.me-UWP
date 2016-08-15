using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using Proxer.me_UWP.Base;
using ProxerMeApi.Interfaces.Values;
using Template10.Mvvm;
using Template10.Services.NavigationService;

namespace Proxer.me_UWP.ViewModels
{
    public class ConferencesPageViewModel : ViewModelBase
    {
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
                ConferenceCollectionValues = (IBaseCollectionValue<IConferenceValue>)suspensionState[nameof(ConferenceCollectionValues)];
            }
            else
            {
                ConferenceCollectionValues = ProxerMeBase.ConferenceHandler.GetAllConferences();
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(ConferenceCollectionValues)] = ConferenceCollectionValues;
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        private IBaseCollectionValue<IConferenceValue> m_ConferenceCollectionValues;

        public IBaseCollectionValue<IConferenceValue> ConferenceCollectionValues
        {
            get { return m_ConferenceCollectionValues; }
            set { Set(ref m_ConferenceCollectionValues, value); }
        }
    }
}