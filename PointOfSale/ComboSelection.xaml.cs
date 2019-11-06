/* ComboSelection.xaml.cs
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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        private CretaceousCombo combo;

        public ComboSelection()
        {
            InitializeComponent();
        }

        private void ButtonClickEntreeComboSelection(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender as Button == BrontoButton)
                {
                    combo = new CretaceousCombo(new Brontowurst());
                    order.Add(combo);
                }
                else if (sender as Button == NugButton)
                {
                    combo = new CretaceousCombo(new DinoNuggets());
                    order.Add(combo);
                }
                else if (sender as Button == PBJButton)
                {
                    combo = new CretaceousCombo(new PrehistoricPBJ());
                    order.Add(combo);
                }
                else if (sender as Button == PteroButton)
                {
                    combo = new CretaceousCombo(new PterodactylWings());
                    order.Add(combo);
                }
                else if (sender as Button == SteakButton)
                {
                    combo = new CretaceousCombo(new SteakosaurusBurger());
                    order.Add(combo);
                }
                else if (sender as Button == KingButton)
                {
                    combo = new CretaceousCombo(new TRexKingBurger());
                    order.Add(combo);
                }
                else if (sender as Button == VeloButton)
                {
                    combo = new CretaceousCombo(new VelociWrap());
                    order.Add(combo);
                }
            }
            NavigationService.Navigate(new CustomizeCombo(combo));
        }

    }
}
