using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Navigation;
using Proxer.me_UWP.Base;
using ProxerMeApi.Implementation.Values;
using ProxerMeApi.Interfaces.Values;
using Template10.Common;
using Template10.Mvvm;
using Template10.Services.NavigationService;

namespace Proxer.me_UWP.ViewModels
{
    public class ConferencesPageViewModel : ViewModelBase
    {
        private DispatcherTimer m_CheckForNewMessages;
        public ConferencesPageViewModel()
        {
            ConferenceCollectionValues = new BaseCollectionValue<IConferenceValue>();
            m_CheckForNewMessages = new DispatcherTimer {Interval = new TimeSpan(0, 0, 15)};
            m_CheckForNewMessages.Tick += CheckForNewMessages_Tick;
        }

        #region Overrides

        public override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, IDictionary<string, object> suspensionState)
        {
            IsMasterLoading = true;
            Selected = null;
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                ConferenceCollectionValues = ProxerMeBase.ConferenceHandler.GetAllConferences();
                Selected = ConferenceCollectionValues.Data?.FirstOrDefault();
                IsMasterLoading = false;
            }, 2000);

            ConferenceMessageValues = new ObservableCollection<IConferenceMessageValue>();

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

        #endregion

        #region Methods

        private void ExecuteNextCommand()
        {
            if (Selected == null)
            {
                return;
            }

            int index = ConferenceCollectionValues.Data.IndexOf(m_Selected);

            if (index == -1)
            {
                return;
            }

            int next = index + 1;
            //Selected = ConferenceCollectionValues.Data[next];
        }

        private bool CanExecuteNextCommand()
        {
            if (Selected == null)
            {
                return false;
            }

            int index = ConferenceCollectionValues.Data.IndexOf(m_Selected);

            if (index == -1)
            {
                return false;
            }

            return index < (ConferenceCollectionValues.Data.Count - 1);
        }

        private bool CanExecutePreviousCommand()
        {
            if (Selected == null)
                return false;
            var index = ConferenceCollectionValues.Data.IndexOf(m_Selected);
            return index > 0;
        }

        private void ExecutePreviousCommand()
        {
            if (Selected == null)
                return;
            var index = ConferenceCollectionValues.Data.IndexOf(m_Selected);
            if (index == -1)
                return;
            var previous = index - 1;
            //Selected = ConferenceCollectionValues.Data[previous];
        }

        public void LoadMessagesFromConference(int conferenceId)
        {
            ConferenceMessageValues = new ObservableCollection<IConferenceMessageValue>(ProxerMeBase.ConferenceHandler.GetMessagesFromConferenceByConferenceId(conferenceId).Data);
        }

        private void CheckForNewMessages_Tick(object sender, object e)
        {
            if (Selected != null)
            {
                LoadMessagesFromConference(((IConferenceValue)Selected).Id);
            }
        }

        #endregion

        #region VALUES

        #region privates

        private IBaseCollectionValue<IConferenceValue> m_ConferenceCollectionValues;
        private ObservableCollection<IConferenceMessageValue> m_ConferenceMessageValues;
        private IConferenceValue m_Selected = default(IConferenceValue);
        private bool m_IsDetailLoading;
        private bool m_IsMasterLoading;
        private string m_TextMessage;

        #endregion

        #region publics

        public IBaseCollectionValue<IConferenceValue> ConferenceCollectionValues
        {
            get { return m_ConferenceCollectionValues; }
            set { Set(ref m_ConferenceCollectionValues, value); }
        }

        public ObservableCollection<IConferenceMessageValue> ConferenceMessageValues
        {
            get { return m_ConferenceMessageValues; }
            set { Set(ref m_ConferenceMessageValues, value); }
        }

        public object Selected
        {
            get { return m_Selected; }
            set
            {
                if (IsDetailsLoading)
                {
                    return;
                }

                IConferenceValue message = value as IConferenceValue;
                Set(ref m_Selected, message);
                NextCommand.RaiseCanExecuteChanged();
                PreviousCommand.RaiseCanExecuteChanged();
                if (message == null)
                {
                    return;
                }
                
                IsDetailsLoading = true;
                WindowWrapper.Current().Dispatcher.Dispatch(() =>
                {
                    LoadMessagesFromConference(message.Id);
                    IsDetailsLoading = false;
                    m_CheckForNewMessages.Start();
                }, 1000);
            }
        }

        public bool IsDetailsLoading
        {
            get { return m_IsDetailLoading;}
            set { Set(ref m_IsDetailLoading, value); }
        }

        public bool IsMasterLoading
        {
            get { return m_IsMasterLoading; }
            set { Set(ref m_IsMasterLoading, value); }
        }

        public string TextMessage
        {
            get { return m_TextMessage; }
            set { Set(ref m_TextMessage, value); }
        }

        #endregion

        #endregion

        #region DelegateCommands

        #region privates

        private DelegateCommand<int> m_LoadMessages;
        private DelegateCommand m_NextCommand;
        private DelegateCommand m_PreviousCommand;
        private DelegateCommand m_SendCommand;

        #endregion

        #region publics
        public DelegateCommand<int> LoadMessages => m_LoadMessages ?? (m_LoadMessages = new DelegateCommand<int>(LoadMessagesFromConference));

        public DelegateCommand NextCommand
        {
            get { return m_NextCommand ?? (m_NextCommand = new DelegateCommand(ExecuteNextCommand, CanExecuteNextCommand)); }
            set { Set(ref m_NextCommand, value); }
        }

        public DelegateCommand PreviousCommand
        {
            get
            {
                return m_PreviousCommand??
                       (m_PreviousCommand = new DelegateCommand(ExecutePreviousCommand, CanExecutePreviousCommand));
            }
            set { Set(ref m_PreviousCommand, value); }
        }

        public DelegateCommand SendCommand => m_SendCommand ?? (m_SendCommand = new DelegateCommand(async () =>
        {
            if (!string.IsNullOrEmpty(TextMessage) && Selected != null)
            {
                IConferenceValue conferenceValue = (IConferenceValue)Selected;

                try
                {
                    m_CheckForNewMessages.Stop();
                    ProxerMeBase.ConferenceHandler.SetMessage(conferenceValue.Id, TextMessage);
                    TextMessage = string.Empty;
                    LoadMessagesFromConference(conferenceValue.Id);
                    m_CheckForNewMessages.Start();
                }
                catch (Exception)
                {
                    await new MessageDialog("Beim Senden ist es problem aufgetreten, bitte versuchen Sie es später noch einmal").ShowAsync();
                }
            }
        }));

        #endregion

        #endregion
    }
}