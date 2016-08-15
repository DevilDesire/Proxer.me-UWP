using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;
using Proxer.me_UWP.Base;
using Proxer.me_UWP.Utils;
using ProxerMeApi.Interfaces.Values;
using Template10.Mvvm;
using Template10.Services.NavigationService;

namespace Proxer.me_UWP.ViewModels
{
    public class NewsPageViewModel : ViewModelBase
    {
        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            if (suspensionState.Any())
            {
                NewsCollectionValues = (IBaseCollectionValue<INewsValue>)suspensionState[nameof(NewsCollectionValues)];
            }
            else
            {
                NewsCollectionValues = ProxerMeBase.NotificationGetter.GetNews(ApplicationKeys.ApiVersion, ApplicationKeys.ApiTokenKey);
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(NewsCollectionValues)] = NewsCollectionValues;
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        private IBaseCollectionValue<INewsValue> m_NewsCollectionValues;

        public IBaseCollectionValue<INewsValue> NewsCollectionValues
        {
            get { return m_NewsCollectionValues; }
            set { Set(ref m_NewsCollectionValues, value); }
        }

        //TODO: Create DelegateCommands => Navigate ForumPost
    }
}