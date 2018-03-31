using LearningUWP_XAML.Pages;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace LearningUWP_XAML
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Go to the home page
            MainFrame.Navigate(typeof(HomePage));
        }

        private void GoHome_Click(object sender, RoutedEventArgs e)
        {
            // Go to the Home page
            MainFrame.Navigate(typeof(HomePage));
        }

        private void GoToLists_Click(object sender, RoutedEventArgs e)
        {
            // Go to the List page
            MainFrame.Navigate(typeof(ListPage));
        }

        private void GoToControls_Click(object sender, RoutedEventArgs e)
        {
            // Go to the Controls page
            MainFrame.Navigate(typeof(ControlsPage));
        }

        private void GoToCharts_Click(object sender, RoutedEventArgs e)
        {
            // Go to the Charts page
            MainFrame.Navigate(typeof(ChartsPage));
        }

        private void GoToMaps_Click(object sender, RoutedEventArgs e)
        {
            // Go to the Maps page
            MainFrame.Navigate(typeof(MapsPage));
        }

        private void GoToInk_Click(object sender, RoutedEventArgs e)
        {
            // Go to the Ink page
            MainFrame.Navigate(typeof(InkPage));
        }
    }
}
