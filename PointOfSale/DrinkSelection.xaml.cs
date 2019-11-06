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
        private Drink drink;
        private CretaceousCombo combo;
        private bool isCombo;
        public DrinkSelection()
        {
            isCombo = false;
            InitializeComponent();
        }

        public DrinkSelection(Drink drink)
        {
            isCombo = false;
            this.drink = drink;
            InitializeComponent();
            if(drink is JurassicJava)
            {
                resetButtons();
                Decaf.IsEnabled = true;
                Decaf.Opacity = 1;
                AddIce.IsEnabled = true;
                AddIce.Opacity = 1;
            }
            else if(drink is Tyrannotea)
            {
                resetButtons();
                Sweet.IsEnabled = true;
                Sweet.Opacity = 1;
                AddLemon.IsEnabled = true;
                AddLemon.Opacity = 1;
                AddIce.IsEnabled = true;
                AddIce.Opacity = 1;
            }
            else if(drink is Sodasaurus)
            {
                resetButtons();
                Flavor.IsEnabled = true;
                Flavor.Opacity = 1;
                AddIce.IsEnabled = true;
                AddIce.Opacity = 1;
            }
            else if(drink is Water)
            {
                resetButtons();
                AddLemon.IsEnabled = true;
                AddLemon.Opacity = 1;
                HoldIce.IsEnabled = true;
                HoldIce.Opacity = 1;
            }
            DisableDrinkButtons();
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            this.combo = combo;
            this.drink = this.combo.Drink;
            isCombo = true;
            InitializeComponent();
        }

        /*public DrinkSelection(string drink)
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
        */

        private void ButtonClickDrinkSize(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Grid parent = (Grid)b.Parent;
            TextBlock size = (TextBlock)b.Content;
            string sizeString = size.Text.ToString();
            if (drink != null)
            {
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
                drink.Size = SelectedSize;
            }
        }

        private void OnDoneClicked(object sender, RoutedEventArgs args)
        {
            if (isCombo) NavigationService.Navigate(new CustomizeCombo(combo));
            else NavigationService.Navigate(new MenuCategorySelection());
        }

        /*private void ChangeSize(object sender, RoutedEventArgs args)
        {
            ButtonClickDrinkSize(sender, args);
            if (DataContext is Order order)
            {
                drink.Size = SelectedSize
            }
        }*/

        private void MakeDecaf(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                if(drink is JurassicJava java)
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
                if (drink is Tyrannotea tea )
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
                if (drink is Tyrannotea tea)
                {
                    tea.AddLemon();
                }
                else if(drink is Water water)
                {
                    water.AddLemon();
                }
            }
        }

        private void HoldTheIce(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (drink is JurassicJava java)
                    java.AddIce();
                else
                    drink.HoldIce();
            }
        }

        private void ChangeFlavors(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                NavigationService?.Navigate(new FlavorSelection(drink));
            }
        }

        private void OnAddDrink(object sender, RoutedEventArgs args)
        {
            Button drinkButton = sender as Button;
            TextBlock buttonText = drinkButton.Content as TextBlock;
            if (DataContext is Order order)
            {
                switch (buttonText.Text.ToString())
                {
                    case ("Sodasaurus"):
                        drink = new Sodasaurus();
                        if (combo != null) combo.Drink = drink;
                        ButtonClickDrinkSodasaurus();
                        break;
                    case ("Tyrannotea"):
                        drink = new Tyrannotea();
                        if (combo != null) combo.Drink = drink;
                        ButtonClickDrinkTyrannotea();
                        break;
                    case ("Jurassic Java"):
                        drink = new JurassicJava();
                        if (combo != null) combo.Drink = drink;
                        ButtonClickDrinkJurrasicJava();
                        break;
                    case ("Water"):
                        drink = new Water();
                        if (combo != null) combo.Drink = drink;
                        ButtonClickDrinkWater();
                        break;
                }
                if(!isCombo) order.Add(drink);
                DisableDrinkButtons();
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

        private void DisableDrinkButtons()
        {
            SodaButton.IsEnabled = false;
            JavaButton.IsEnabled = false;
            WaterButton.IsEnabled = false;
            TeaButton.IsEnabled = false;
        }

        private void ButtonClickDrinkSodasaurus()
        {
            resetButtons();
            Flavor.IsEnabled = true;
            Flavor.Opacity = 1;
            HoldIce.IsEnabled = true;
            HoldIce.Opacity = 1;
            HoldIce.Visibility = Visibility.Visible;
            AddIce.Visibility = Visibility.Collapsed;
        }

        private void ButtonClickDrinkTyrannotea()
        {
            resetButtons();
            Sweet.IsEnabled = true;
            Sweet.Opacity = 1;
            AddLemon.IsEnabled = true;
            AddLemon.Opacity = 1;
            HoldIce.IsEnabled = true;
            HoldIce.Opacity = 1;
            HoldIce.Visibility = Visibility.Visible;
            AddIce.Visibility = Visibility.Collapsed;
        }

        private void ButtonClickDrinkJurrasicJava()
        {
            resetButtons();
            Decaf.IsEnabled = true;
            Decaf.Opacity = 1;
            AddIce.IsEnabled = true;
            AddIce.Opacity = 1;
            AddIce.Visibility = Visibility.Visible;
            HoldIce.Visibility = Visibility.Collapsed;
        }

        private void ButtonClickDrinkWater()
        {
            
            resetButtons();
            AddLemon.IsEnabled = true;
            AddLemon.Opacity = 1;
            HoldIce.IsEnabled = true;
            HoldIce.Opacity = 1;
            HoldIce.Visibility = Visibility.Visible;
            AddIce.Visibility = Visibility.Collapsed;
        }
    }
}
