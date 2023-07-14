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
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();

            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

            
        //From Home Page to Game Settings Page
        private void GotoGameSettingsPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(GameSettingsPage));
        }

        //From Home Page to Leaderbaord Page
        private void GotoLeaderboardPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LeaderboardPage));
        }

        //From Home page to Patreon Page
        private void GotoPatreonPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(PatreonPage));
        }

        //From Home page to Suggestion Page
        private void GotoSuggestionPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(SuggestionPage));
        }

        //From Home page to User Settings Page
        private void GotoUserSettingsPageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UserSettingsPage));
        }

        //From Home page to Store Page
        private void GotoStorePageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(StorePage));
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Lock the device sizing for the application
            //ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
        }
    }
}
