/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// keeps track of the current size
        /// </summary>
        public string SelectedSize { get; private set; }
        public DrinkSelection()
        {
            InitializeComponent();
        }

        private void ButtonClickDrinkSize(object sender, RoutedEventArgs e)
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

        private void resetButtons(Grid grid)
        {
            for(int i = 1; i < grid.Children.Count; i++)
            {
                Button temp = (Button)grid.Children[i];
                temp.IsEnabled = false;
                temp.Opacity = 0;
            }
        }

        private void ButtonClickDrinkSodasaurus(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Grid parent = (Grid)b.Parent;
            Grid parentParent = (Grid)parent.Parent;
            Grid specialGrid = (Grid)parentParent.Children[3];
            resetButtons(specialGrid);
            Button flavor = (Button)specialGrid.Children[1];
            flavor.IsEnabled = true;
            flavor.Opacity = 1;
            Button ice = (Button)specialGrid.Children[5];
            ice.IsEnabled = true;
            ice.Opacity = 1;
        }

        private void ButtonClickDrinkTyrannotea(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Grid parent = (Grid)b.Parent;
            Grid parentParent = (Grid)parent.Parent;
            Grid specialGrid = (Grid)parentParent.Children[3];
            resetButtons(specialGrid);
            Button sweet = (Button)specialGrid.Children[3];
            sweet.IsEnabled = true;
            sweet.Opacity = 1;
            Button lemon = (Button)specialGrid.Children[4];
            lemon.IsEnabled = true;
            lemon.Opacity = 1;
            Button ice = (Button)specialGrid.Children[5];
            ice.IsEnabled = true;
            ice.Opacity = 1;
        }

        private void ButtonClickDrinkJurrasicJava(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Grid parent = (Grid)b.Parent;
            Grid parentParent = (Grid)parent.Parent;
            Grid specialGrid = (Grid)parentParent.Children[3];
            resetButtons(specialGrid);
            Button decaf = (Button)specialGrid.Children[2];
            decaf.IsEnabled = true;
            decaf.Opacity = 1;
            Button ice = (Button)specialGrid.Children[5];
            ice.IsEnabled = true;
            ice.Opacity = 1;
        }

        private void ButtonClickDrinkWater(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Grid parent = (Grid)b.Parent;
            Grid parentParent = (Grid)parent.Parent;
            Grid specialGrid = (Grid)parentParent.Children[3];
            resetButtons(specialGrid);
            Button lemon = (Button)specialGrid.Children[4];
            lemon.IsEnabled = true;
            lemon.Opacity = 1;
            Button ice = (Button)specialGrid.Children[5];
            ice.IsEnabled = true;
            ice.Opacity = 1;
        }

        private void ButtonClickComboFlavorSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
