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

namespace GoNuts
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffee : Page
    {
        private string _roast, _sugar, _cream;
        public Coffee()
        {
            this.InitializeComponent();
        }
        

        private void RoastNone_Click(object sender, RoutedEventArgs e)
        {
            var Selected = (MenuFlyoutItem)sender;
            _roast = Selected.Text;
            ShowCoffeeType();
        }

        private void SugarNone_Click(object sender, RoutedEventArgs e)
        {
            var Selected = (MenuFlyoutItem)sender;
            _sugar = Selected.Text;
            ShowCoffeeType();
        }

        private void CreamNone_Click(object sender, RoutedEventArgs e)
        {
            var Selected = (MenuFlyoutItem)sender;
            _cream = Selected.Text;
            ShowCoffeeType();
        }

        private void ShowCoffeeType()
        {
            if (_roast != "None" && !string.IsNullOrEmpty(_roast))
            {
                CoffeeType.Text = _roast;

                if (_cream != "None" && !string.IsNullOrEmpty(_cream))
                    CoffeeType.Text += " + " + _cream;

                if (_sugar != "None" && !string.IsNullOrEmpty(_sugar))
                    CoffeeType.Text += " + " + _sugar;
            
            }

            else CoffeeType.Text = "None";
        }
    }
}
