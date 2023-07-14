using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238
// Setup the device sizing for the application
using Windows.UI.ViewManagement;

namespace VNguesserStructure
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GameSettingsPage : Page
    {
        public GameSettingsPage()
        {
            this.InitializeComponent();

            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        //From Settings to Game Lobby Page
        private void GotoGameLobbyPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameLobbyPage));
        }

        //From Settings back to Home Page
        private void GotoHomePageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }

        //Game Settings Page Round Slider 
        private void MySlider_ValueChangedS(object sender, RangeBaseValueChangedEventArgs e)
        {
            SliderRResult.Text = String.Format("{0}", e.NewValue);
        }

        //Game Settings Page Guess Time Slider 
        private void MySlider_ValueChangedT(object sender, RangeBaseValueChangedEventArgs e)
        {
            SliderTResult.Text = String.Format("{0}", e.NewValue);
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Lock the device sizing for the application
            //ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
        }
    }
}
