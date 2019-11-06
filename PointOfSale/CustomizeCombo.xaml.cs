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
using DinoDiner.Menu;

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

        private CretaceousCombo combo;
        private Drink drink;
        private Side side;

        public CustomizeCombo()
        {
            InitializeComponent();
        }

        public CustomizeCombo(CretaceousCombo combo)
        {
            this.combo = combo;
            this.drink = combo.Drink;
            this.side = combo.Side;
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
                    combo.Side.Size = DinoDiner.Menu.Size.Small;
                    //combo.Side = side;
                    combo.Drink.Size = DinoDiner.Menu.Size.Small;
                    //combo.Drink = drink;
                    break;
                case ("Medium"):
                    SelectedSize = "medium";
                    combo.Side.Size = DinoDiner.Menu.Size.Medium;
                    //combo.Side = side;
                    combo.Drink.Size = DinoDiner.Menu.Size.Medium;
                    //combo.Drink = drink;
                    break;
                case ("Large"):
                    SelectedSize = "large";
                    combo.Side.Size = DinoDiner.Menu.Size.Large;
                    //combo.Side = side;
                    combo.Drink.Size = DinoDiner.Menu.Size.Large;
                    //combo.Drink = drink;
                    break;
            }

        }

        private void ButtonClickDone(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void ButtonClickComboSideSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(combo));
        }
        private void ButtonClickComboDrinkSelection(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(combo));
        }

        private void OnCustomizeEntreeClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeCustomization(combo));
        }

    }
}
