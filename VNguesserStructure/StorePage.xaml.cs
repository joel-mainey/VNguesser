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
    public sealed partial class StorePage : Page
    {
        public StorePage()
        {
            this.InitializeComponent();

            StoreListBox.ItemsSource = storeDictionary.Keys;

            // setup the device sizing for the application
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;
        }

        Dictionary<string, Store> storeDictionary = new Dictionary<string, Store>()
        {
            {"Purple", new Store() { Name="Purple", ImageName="Yukari_Purple_Common.png", Buy="Buy Purple", Price="40,000"}},
            {"Blue", new Store() { Name="Blue", ImageName="Yukari_Blue_Common.png", Buy="Buy Blue", Price="40,000"}},
            {"White", new Store() { Name="White", ImageName="Yukari_White_Common.png", Buy="Buy White", Price="40,000"}},
            {"Coral", new Store() { Name="Coral", ImageName="Yukari_Coral_Uncommon.png", Buy="Buy Coral", Price="80,000"}},
            {"Teal", new Store() { Name="Teal", ImageName="Yukari_Teal_Uncommon.png", Buy="Buy Teal", Price="80,000"}},
            {"Shorthair", new Store() { Name="Shorthair", ImageName="Yukari_Shorthair_Rare.png", Buy="Buy Shorthair", Price="120,000"}},
            {"Blue Russian", new Store() { Name="Blue Russian", ImageName="Yukari_Blue_Russian_Rare.png", Buy="Buy Blue Russian", Price="120,000"}},
            {"Siamase", new Store() { Name="Siamase", ImageName="Yukari_Siamase_Rare.png", Buy="Buy Siamase", Price="120,000"}},
            {"Bengal", new Store() { Name="Bengal", ImageName="Yukari_Bengal_Legendary.png", Buy="Buy Bengal", Price="200,000"}},
            {"Calico", new Store() { Name="Calico", ImageName="Yukari_Calico_Legendary.png", Buy="Buy Calico", Price="200,000"}}
        };

        //store list selection changed
        private void StoreListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string itemSlected = StoreListBox.SelectedItem.ToString();

            if (storeDictionary.ContainsKey(itemSlected) == false)
            {
                StoreName.Text = StoreName.Text + "\nkey " + itemSlected + " not found";

                StoreImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/store_items/Yukari_Purple_Common.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                Store theStore = storeDictionary[itemSlected];

                StoreName.Text = theStore.Name.ToString();

                StoreImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/store_items/" + theStore.ImageName.ToString(), UriKind.RelativeOrAbsolute));

                StoreBuy.Content = theStore.Buy.ToString();

                StorePrice.Text = theStore.Price.ToString();
            }
        }

        // From Store Page to Home Page 
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
