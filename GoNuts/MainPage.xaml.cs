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

namespace GoNuts
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            SecondaryFrame.Navigate(typeof(Donuts));
        }

        private void ButtonDonut_Click(object sender, RoutedEventArgs e)
        {
            SecondaryFrame.Navigate(typeof(Donuts));
        }

        private void ButtonCoffee_Click(object sender, RoutedEventArgs e)
        {
            SecondaryFrame.Navigate(typeof(Coffee));
        }

        private void ButtonSchedule_Click(object sender, RoutedEventArgs e)
        {
            SecondaryFrame.Navigate(typeof(Schedule));
        }

        private void ButtonComplete_Click(object sender, RoutedEventArgs e) 
        {
            SecondaryFrame.Navigate(typeof(Complete));
        }
    }
}
