/* EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        private Entree entree;
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public void OnAddEntree(object sender, RoutedEventArgs args)
        {
            Button entreeButton = sender as Button;
            TextBlock buttonText = entreeButton.Content as TextBlock;
            Entree entree = null;
            if (DataContext is Order order)
            {
                switch (buttonText.Text.ToString())
                {
                    case ("Brontowurst"):
                        entree = new Brontowurst();
                        break;
                    case ("Dino-Nugget"):
                        entree = new DinoNuggets();
                        break;
                    case ("Prehistoric PB&J"):
                        entree = new PrehistoricPBJ();
                        break;
                    case ("Pterodactyl Wings"):
                        entree = new PterodactylWings();
                        break;
                    case ("Steakosaurus Burger"):
                        entree = new SteakosaurusBurger();
                        break;
                    case ("T-Rex Kingburger"):
                        entree = new TRexKingBurger();
                        break;
                    case ("Veloci-Wrap"):
                        entree = new VelociWrap();
                        break;
                }
                this.entree = entree;
                order.Add(entree);
                if(entree is PterodactylWings) 
                    NavigationService.Navigate(new MenuCategorySelection());
                else
                    NavigationService.Navigate(new EntreeCustomization(this.entree));
            }
        }
    }
}
