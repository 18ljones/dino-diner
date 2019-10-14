/* CustomizeCombo.xaml.cs
 * Author: Logan Jones
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Keeps track of the selected size
        /// </summary>
        public string SelectedSize { get; private set; }

        public CustomizeCombo()
        {
            InitializeComponent();
        }

        private void ButtonClickSize(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Grid parent = (Grid)b.Parent;
            TextBlock size = (TextBlock)b.Content;
            string sizeString = size.Text.ToString();

            for (int i = 1; i < parent.Children.Count; i++)
            {
                Button temp = (Button)parent.Children[i];
                temp.Background = Brushes.LightGray;
            }
            b.Background = Brushes.LightSteelBlue;

            switch (sizeString)
            {
                case ("Small"):
                    SelectedSize = "small";
                    break;
                case ("Medium"):
                    SelectedSize = "medium";
                    break;
                case ("Large"):
                    SelectedSize = "large";
                    break;
            }

        }

        private void ButtonClickComboSideSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        private void ButtonClickComboDrinkSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
