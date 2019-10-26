/* FlavorSelection.xaml.cs
 * Author: Logan Jones
 */
using DinoDiner.Menu;
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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        public FlavorSelection()
        {
            InitializeComponent();
        }

        private void ChooseFlavor(object sender, RoutedEventArgs args)
        {
            Button flavorButton = sender as Button;
            TextBlock buttonText = flavorButton.Content as TextBlock;
            string buttonString = buttonText.Text.ToString();
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus drink)
                {
                    switch (buttonString)
                    {
                        case ("Cherry"):
                            drink.Flavor = SodasaurusFlavor.Cherry;
                            break;
                        case ("Chocolate"):
                            drink.Flavor = SodasaurusFlavor.Chocolate;
                            break;
                        case ("Cola"):
                            drink.Flavor = SodasaurusFlavor.Cola;
                            break;
                        case ("Lime"):
                            drink.Flavor = SodasaurusFlavor.Lime;
                            break;
                        case ("Orange"):
                            drink.Flavor = SodasaurusFlavor.Orange;
                            break;
                        case ("Rootbeer"):
                            drink.Flavor = SodasaurusFlavor.RootBeer;
                            break;
                        case ("Vanilla"):
                            drink.Flavor = SodasaurusFlavor.Vanilla;
                            break;
                    }
                }
            }
            NavigationService.Navigate(new DrinkSelection("sodasaurus"));
        }
    }
}
