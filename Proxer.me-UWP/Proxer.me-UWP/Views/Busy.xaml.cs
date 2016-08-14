﻿using Windows.UI.Xaml;
using Template10.Common;
using Template10.Controls;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Proxer.me_UWP.Views
{
    public sealed partial class Busy
    {
        public Busy()
        {
            InitializeComponent();
        }

        public string BusyText
        {
            get { return (string)GetValue(BusyTextProperty); }
            set { SetValue(BusyTextProperty, value); }
        }
        public static readonly DependencyProperty BusyTextProperty =
            DependencyProperty.Register(nameof(BusyText), typeof(string), typeof(Busy), new PropertyMetadata("Please wait..."));

        public bool IsBusy
        {
            get { return (bool)GetValue(IsBusyProperty); }
            set { SetValue(IsBusyProperty, value); }
        }
        public static readonly DependencyProperty IsBusyProperty =
            DependencyProperty.Register(nameof(IsBusy), typeof(bool), typeof(Busy), new PropertyMetadata(false));

        // hide and show busy dialog
        public static void SetBusy(bool busy, string text = null)
        {
            WindowWrapper.Current().Dispatcher.Dispatch(() =>
            {
                var modal = Window.Current.Content as ModalDialog;
                var view = modal.ModalContent as Busy;
                if (view == null)
                    modal.ModalContent = view = new Busy();
                modal.IsModal = view.IsBusy = busy;
                view.BusyText = text;
            });
        }
    }
}
