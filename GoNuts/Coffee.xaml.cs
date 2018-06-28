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
        public Coffee()
        {
            this.InitializeComponent();
        }


        private void MenuFlyout_Closing(FlyoutBase sender, FlyoutBaseClosingEventArgs args)
        {
            SelectedText.Text += "\t";
            if(RoastDark.IsChecked)
                SelectedText.Text += "Roast: Dark + ";
            else if (RoastMedium.IsChecked)
                SelectedText.Text += "Roast: Medium + ";
            else if (RoastNone.IsChecked)
                SelectedText.Text += "Roast: None + ";
        }

        private void MenuFlyout_Closing_1(FlyoutBase sender, FlyoutBaseClosingEventArgs args)
        {
            if (SugarExtra.IsChecked)
                SelectedText.Text += "Sugar: Extra + ";
            else if (SugarMedium.IsChecked)
                SelectedText.Text += "Sugar: Medium + ";
            else if (SugarNone.IsChecked)
                SelectedText.Text += "Sugar: None + ";
        }
        private void MenuFlyout_Closing_2(FlyoutBase sender, FlyoutBaseClosingEventArgs args)
        {
            if (CreamFullMilk.IsChecked)
                SelectedText.Text += "Cream: Full Milk";
            else if (CreamMedium.IsChecked)
                SelectedText.Text += "Cream: 2% Milk";
            else if (CreamNone.IsChecked)
                SelectedText.Text += "Cream: None";
        }
    }
}
