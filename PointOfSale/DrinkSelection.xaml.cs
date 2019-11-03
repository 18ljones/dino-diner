/* DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// keeps track of the current size
        /// </summary>
        public DinoDiner.Menu.Size SelectedSize { get; private set; }
        public DrinkSelection()
        {
            InitializeComponent();
        }

        public DrinkSelection(string drink)
        {
            InitializeComponent();
            switch(drink.ToLower()){
                case ("sodasaurus"):
                    Flavor.IsEnabled = true;
                    Flavor.Opacity = 1;
                    HoldIce.IsEnabled = true;
                    HoldIce.Opacity = 1;
                    break;
            }
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
                    SelectedSize = DinoDiner.Menu.Size.Small;
                    break;
                case ("Medium"):
                    SelectedSize = DinoDiner.Menu.Size.Medium;
                    break;
                case ("Large"):
                    SelectedSize = DinoDiner.Menu.Size.Large;
                    break;
            }
        }

        private void OnDoneClicked(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void ChangeSize(object sender, RoutedEventArgs args)
        {
            ButtonClickDrinkSize(sender, args);
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = SelectedSize;
                }
            }
        }

        private void MakeDecaf(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    if (!java.Decaf)
                        java.Decaf = true;
                    else
                        java.Decaf = false;
                }
            }
        }

        private void MakeSweet(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    if (!tea.Sweet)
                        tea.Sweet = true;
                    else
                        tea.Sweet = false;
                }
            }
        }

        private void AddSomeLemon(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                else if(CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water)
                {
                    water.AddLemon();
                }
            }
        }

        private void HoldTheIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is JurassicJava java)
                        java.AddIce();
                    else
                        drink.HoldIce();
                }
            }
        }

        private void ChangeFlavors(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                NavigationService?.Navigate(new FlavorSelection());
            }
        }

        private void OnAddDrink(object sender, RoutedEventArgs args)
        {
            Button drinkButton = sender as Button;
            TextBlock buttonText = drinkButton.Content as TextBlock;
            Drink drink = null;
            if (DataContext is Order order)
            {
                switch (buttonText.Text.ToString())
                {
                    case ("Sodasaurus"):
                        drink = new Sodasaurus();
                        ButtonClickDrinkSodasaurus(sender, args);
                        break;
                    case ("Tyrannotea"):
                        drink = new Tyrannotea();
                        ButtonClickDrinkTyrannotea(sender, args);
                        break;
                    case ("Jurassic Java"):
                        drink = new JurassicJava();
                        ButtonClickDrinkJurrasicJava(sender, args);
                        break;
                    case ("Water"):
                        drink = new Water();
                        ButtonClickDrinkWater(sender, args);
                        break;
                }
                order.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        private void resetButtons()
        {
            Flavor.IsEnabled = false;
            Flavor.Opacity = 0;
            Decaf.IsEnabled = false;
            Decaf.Opacity = 0;
            Sweet.IsEnabled = false;
            Sweet.Opacity = 0;
            AddLemon.IsEnabled = false;
            AddLemon.Opacity = 0;
            HoldIce.IsEnabled = false;
            HoldIce.Opacity = 0;
            AddIce.IsEnabled = false;
            AddIce.Opacity = 0;
        }

        private void ButtonClickDrinkSodasaurus(object sender, RoutedEventArgs e)
        {
            resetButtons();
            Flavor.IsEnabled = true;
            Flavor.Opacity = 1;
            AddIce.IsEnabled = true;
            AddIce.Opacity = 1;
        }

        private void ButtonClickDrinkTyrannotea(object sender, RoutedEventArgs e)
        {
            resetButtons();
            Sweet.IsEnabled = true;
            Sweet.Opacity = 1;
            AddLemon.IsEnabled = true;
            AddLemon.Opacity = 1;
            AddIce.IsEnabled = true;
            AddIce.Opacity = 1;
        }

        private void ButtonClickDrinkJurrasicJava(object sender, RoutedEventArgs e)
        {
            resetButtons();
            Decaf.IsEnabled = true;
            Decaf.Opacity = 1;
            AddIce.IsEnabled = true;
            AddIce.Opacity = 1;
            
        }

        private void ButtonClickDrinkWater(object sender, RoutedEventArgs e)
        {
            resetButtons();
            AddLemon.IsEnabled = true;
            AddLemon.Opacity = 1;
            HoldIce.IsEnabled = true;
            HoldIce.Opacity = 1;
        }
    }
}
