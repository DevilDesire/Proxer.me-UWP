﻿using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Proxer.me_UWP.Views
{
    public sealed partial class Splash : UserControl
    {
        public Splash(SplashScreen splashScreen)
        {
            this.InitializeComponent();
            Window.Current.SizeChanged += (s, e) => Resize(splashScreen);
        }

        private void Resize(SplashScreen splashScreen)
        {
            if (splashScreen.ImageLocation.Top == 0)
            {
                SplashImage.Visibility = Visibility.Collapsed;
                return;
            }

            RootCanvas.Background = null;
            SplashImage.Visibility = Visibility.Visible;
            SplashImage.Height = splashScreen.ImageLocation.Height;
            SplashImage.Width = splashScreen.ImageLocation.Width;
            SplashImage.SetValue(Canvas.TopProperty, splashScreen.ImageLocation.Top);
            SplashImage.SetValue(Canvas.LeftProperty, splashScreen.ImageLocation.Left);
            ProgressTransform.TranslateY = SplashImage.Height / 2;
        }
    }
}
