using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using ProxerMeApi.Interfaces.Enums;
using ProxerMeApi.Interfaces.Values;

namespace ProxerMeApi.Implementation.Wrapper
{
    public class MessageTemplateSelector : DataTemplateSelector
    {
        public DataTemplate MeUnderYou { get; set; }
        public DataTemplate YouUnderMe { get; set; }
        public DataTemplate YouUnderYou { get; set; }
        public DataTemplate MeUnderMe { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            var message = item as IConferenceMessageValue;

            if (message == null)
            {
                throw new ArgumentException("Es konnte nicht ermittelt werden.");
            }

            if (message.Side == ConversationSide.Me)
            {
                return message.PrevSide == ConversationSide.You ? MeUnderYou : MeUnderMe;
            }

            return message.PrevSide == ConversationSide.You ? YouUnderYou : YouUnderMe;
        }
    }
}