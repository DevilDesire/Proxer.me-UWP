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
                NewsValues = (IBaseValue<INewsValue>)suspensionState[nameof(NewsValues)];
            }
            else
            {
                NewsValues = ProxerMeBase.NotificationGetter.GetNews(ApplicationKeys.ApiVersion, ApplicationKeys.ApiTokenKey);
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatedFromAsync(IDictionary<string, object> suspensionState, bool suspending)
        {
            if (suspending)
            {
                suspensionState[nameof(NewsValues)] = NewsValues;
            }

            await Task.CompletedTask;
        }

        public override async Task OnNavigatingFromAsync(NavigatingEventArgs args)
        {
            args.Cancel = false;
            await Task.CompletedTask;
        }

        private IBaseValue<INewsValue> m_NewsValues;

        public IBaseValue<INewsValue> NewsValues
        {
            get { return m_NewsValues; }
            set { Set(ref m_NewsValues, value); }
        }

        //TODO: Create DelegateCommands => Navigate ForumPost
    }
}