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

using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238
// Setup the device sizing for the application
using Windows.UI.ViewManagement;

namespace VNguesserStructure
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class InGamePage : Page
    {
        public InGamePage()
        {
            this.InitializeComponent();

            number = new Random();

            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        private string[] selectionItems = new string[] { "Fata Morgana", "Higurashi", "Muv Luv", "Muv Luv Altered Fable", "Muv Luv The Day After", "Saya no Uta", "Steins;Gate", "The Silver Case", "The Silver Case 25th Ward", "Umineko" };

        Dictionary<string, Game> gameDictionary = new Dictionary<string, Game>
        {
            {"Fata Morgana", new Game() {Name="Fata Morgana", Image="Fata_Morgana.png"}},
            {"Higurashi", new Game() {Name="Higurashi", Image="Higurashi.png"}},
            {"Muv Luv", new Game() {Name="Muv Luv", Image="Muv_Luv.png"}},
            {"Muv Luv Altered Fable", new Game() {Name="Muv Luv Altered Fable", Image="Muv_Luv_Altered_Fable.png"}},
            {"Muv Luv The Day After", new Game() {Name="Muv Luv The Day After", Image="Muv_Luv_The_Day_After.png"}},
            {"Saya no Uta", new Game() {Name="Saya no Uta", Image="Saya_no_Uta.png"}},
            {"Steins;Gate", new Game() {Name="Steins;Gate", Image="Steins;Gate.png"}},
            {"The Silver Case", new Game() {Name="The Silver Case", Image="The_Silver_Case.png"}},
            {"The Silver Case 25th Ward", new Game() {Name="The Silver Case 25th Ward", Image="The_Silver_Case_25th_Ward.png"}},
            {"Umineko", new Game() {Name="Umineko", Image="Umineko.png"}}
        };

        //auto suggestion box
        private void MyAutoSuggestBox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;

            if (gameDictionary.ContainsKey(sender.Text.ToString()) == false)
            {
                PlayerIcon.Fill.Opacity = 0.2;
            }
            else
            {
                Game theGame = gameDictionary[sender.Text.ToString()];

                PlayerIcon.Fill.Opacity = 1;
            }
        }

        //random num variables
        Random number;
        int rand;

        //displays screenshot at random when button clicked
        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            rand = number.Next(0, 10);

            Game theGame = gameDictionary[gameDictionary.Keys.ElementAt(rand)];

            NameBox.Text = theGame.Name.ToString();

            ScreenshotHolder.Source = new BitmapImage(new Uri("ms-appx:///Assets/game_screenshots/" + theGame.Image.ToString(), UriKind.RelativeOrAbsolute));
        }


        //From In Game Page to Home Page
        private void GotoHomePageButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Lock the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
        }
    }
}
