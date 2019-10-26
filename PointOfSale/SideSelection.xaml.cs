/* SideSelection.xaml.cs
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
using System.Collections.Specialized;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// keeps track of the current size
        /// </summary>
        public DinoDiner.Menu.Size SelectedSize { get; private set; }
        public SideSelection()
        {
            //DataContext = side;
            InitializeComponent();
        }

        public SideSelection(bool isEdit)
        {
            //DataContext = side;
            InitializeComponent();
            if(isEdit)DisableSides();
        }

        private void ButtonClickSideSize(object sender, RoutedEventArgs e)
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

        public void OnAddSide(object sender, RoutedEventArgs args)
        {
            Button sideButton = sender as Button;
            TextBlock buttonText = sideButton.Content as TextBlock;
            Side side = null;
            if (DataContext is Order order)
            {
                switch (buttonText.Text.ToString())
                {
                    case ("Fryceritops"):
                        side = new Fryceritops();
                        break;
                    case ("Meteor Mac & Cheese"):
                        side = new MeteorMacAndCheese();
                        break;
                    case ("Mezzorella Sticks"):
                        side = new MezzorellaSticks();
                        break;
                    case ("Triceritots"):
                        side = new Triceritots();
                        break;
                }
                order.Items.Add(side);
                DisableSides();
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

        public void ChangeSize(object sender, RoutedEventArgs args)
        {
            ButtonClickSideSize(sender, args);
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = SelectedSize;
                }
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void EnableSides()
        {
            AddFryceritops.IsEnabled = true;
            AddMeteorMac.IsEnabled = true;
            AddMezzSticks.IsEnabled = true;
            AddTriceritots.IsEnabled = true;
        }

        private void DisableSides()
        {
            AddFryceritops.IsEnabled = false;
            AddMeteorMac.IsEnabled = false;
            AddMezzSticks.IsEnabled = false;
            AddTriceritots.IsEnabled = false;
        }

        /*public void MakeMedium(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
            }
            ButtonClickSideSize(sender, args);
        }

        public void MakeSmall(object sender, RoutedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
            }
            ButtonClickSideSize(sender, args);
        }
        */

        public void OnCurrentContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    switch (side.Size)
                    {

                    }
                    AddFryceritops.IsEnabled = false;
                }
            }
        }
    }
}
