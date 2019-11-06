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
    /// Interaction logic for EntreeCustomization.xaml
    /// </summary>
    public partial class EntreeCustomization : Page
    {
        private Entree entree;
        private bool isCombo;

        public EntreeCustomization()
        {
            InitializeComponent();
        }

        public EntreeCustomization(Entree entree)
        {
            this.entree = entree;
            isCombo = false;
            InitializeComponent();
            if (entree is Brontowurst) IsBrontowurst();
            else if (entree is DinoNuggets) IsDinoNugget();
            else if (entree is PrehistoricPBJ) IsPBJ();
            else if (entree is TRexKingBurger) IsKingBurger();
            else if (entree is SteakosaurusBurger) IsSteakoBurger();
            else if (entree is VelociWrap) IsVeloWrap();
        }

        public EntreeCustomization(CretaceousCombo combo)
        {
            isCombo = true;
            this.entree = combo.Entree;
            InitializeComponent();
            if (entree is Brontowurst) IsBrontowurst();
            else if (entree is DinoNuggets) IsDinoNugget();
            else if (entree is PrehistoricPBJ) IsPBJ();
            else if (entree is TRexKingBurger) IsKingBurger();
            else if (entree is SteakosaurusBurger) IsSteakoBurger();
            else if (entree is VelociWrap) IsVeloWrap();
        }

        private void OnDoneClicked(object sender, RoutedEventArgs args)
        {
            if (isCombo) NavigationService.GoBack();
            else NavigationService.Navigate(new MenuCategorySelection());
        }

        private void ResetButtons()
        {
            HoldBun.IsEnabled = false;
            HoldBun.Opacity = 0;
            HoldKetchup.IsEnabled = false;
            HoldKetchup.Opacity = 0;
            AddNugget.IsEnabled = false;
            AddNugget.Opacity = 0;
            HoldMustard.IsEnabled = false;
            HoldMustard.Opacity = 0;
            HoldPB.IsEnabled = false;
            HoldPB.Opacity = 0;
            HoldOnion.IsEnabled = false;
            HoldOnion.Opacity = 0;
            HoldDressing.IsEnabled = false;
            HoldDressing.Opacity = 0;
            HoldPickle.IsEnabled = false;
            HoldPickle.Opacity = 0;
            HoldCheese.IsEnabled = false;
            HoldCheese.Opacity = 0;
            RemoveNugget.IsEnabled = false;
            RemoveNugget.Opacity = 0;
            HoldLettuce.IsEnabled = false;
            HoldLettuce.Opacity = 0;
            HoldJelly.IsEnabled = false;
            HoldJelly.Opacity = 0;
            HoldPeppers.IsEnabled = false;
            HoldPeppers.Opacity = 0;
            HoldTomato.IsEnabled = false;
            HoldTomato.Opacity = 0;
            HoldMayo.IsEnabled = false;
            HoldMayo.Opacity = 0;
        }

        private void IsBrontowurst()
        {
            ResetButtons();
            HoldBun.IsEnabled = true;
            HoldBun.Opacity = 1;
            HoldPeppers.IsEnabled = true;
            HoldPeppers.Opacity = 1;
            HoldPeppers.Visibility = Visibility.Visible;
            HoldTomato.Visibility = Visibility.Collapsed;
            HoldOnion.IsEnabled = true;
            HoldOnion.Opacity = 1;
            HoldOnion.Visibility = Visibility.Visible;
            HoldDressing.Visibility = Visibility.Collapsed;
        }

        private void IsDinoNugget()
        {
            ResetButtons();
            AddNugget.IsEnabled = true;
            AddNugget.Opacity = 1;
            AddNugget.Visibility = Visibility.Visible;
            HoldKetchup.Visibility = Visibility.Collapsed;
            RemoveNugget.IsEnabled = true;
            RemoveNugget.Opacity = 1;
            RemoveNugget.Visibility = Visibility.Visible;
            HoldPickle.Visibility = Visibility.Collapsed;
            HoldCheese.Visibility = Visibility.Collapsed;
        }

        private void IsPBJ()
        {
            ResetButtons();
            HoldPB.IsEnabled = true;
            HoldPB.Opacity = 1;
            HoldPB.Visibility = Visibility.Visible;
            HoldMustard.Visibility = Visibility.Collapsed;
            HoldJelly.IsEnabled = true;
            HoldJelly.Opacity = 1;
            HoldJelly.Visibility = Visibility.Visible;
            HoldLettuce.Visibility = Visibility.Collapsed;
        }

        private void IsSteakoBurger()
        {
            ResetButtons();
            HoldBun.IsEnabled = true;
            HoldBun.Opacity = 1;
            HoldPickle.IsEnabled = true;
            HoldPickle.Opacity = 1;
            HoldPickle.Visibility = Visibility.Visible;
            HoldCheese.Visibility = Visibility.Collapsed;
            RemoveNugget.Visibility = Visibility.Collapsed;
            HoldKetchup.IsEnabled = true;
            HoldKetchup.Opacity = 1;
            HoldKetchup.Visibility = Visibility.Visible;
            AddNugget.Visibility = Visibility.Collapsed;
            HoldMustard.IsEnabled = true;
            HoldMustard.Opacity = 1;
            HoldMustard.Visibility = Visibility.Visible;
            HoldPB.Visibility = Visibility.Collapsed;
        }

        private void IsKingBurger()
        {
            ResetButtons();
            HoldBun.IsEnabled = true;
            HoldBun.Opacity = 1;
            HoldLettuce.IsEnabled = true;
            HoldLettuce.Opacity = 1;
            HoldLettuce.Visibility = Visibility.Visible;
            HoldJelly.Visibility = Visibility.Collapsed;
            HoldTomato.IsEnabled = true;
            HoldTomato.Opacity = 1;
            HoldTomato.Visibility = Visibility.Visible;
            HoldPeppers.Visibility = Visibility.Collapsed;
            HoldOnion.IsEnabled = true;
            HoldOnion.Opacity = 1;
            HoldOnion.Visibility = Visibility.Visible;
            HoldDressing.Visibility = Visibility.Collapsed;
            HoldPickle.IsEnabled = true;
            HoldPickle.Opacity = 1;
            HoldPickle.Visibility = Visibility.Visible;
            HoldCheese.Visibility = Visibility.Collapsed;
            RemoveNugget.Visibility = Visibility.Collapsed;
            HoldKetchup.IsEnabled = true;
            HoldKetchup.Opacity = 1;
            HoldKetchup.Visibility = Visibility.Visible;
            AddNugget.Visibility = Visibility.Collapsed;
            HoldMustard.IsEnabled = true;
            HoldMustard.Opacity = 1;
            HoldMustard.Visibility = Visibility.Visible;
            HoldPB.Visibility = Visibility.Collapsed;
            HoldMayo.IsEnabled = true;
            HoldMayo.Opacity = 1;
        }

        private void IsVeloWrap()
        {
            ResetButtons();
            HoldDressing.IsEnabled = true;
            HoldDressing.Opacity = 1;
            HoldDressing.Visibility = Visibility.Visible;
            HoldOnion.Visibility = Visibility.Collapsed;
            HoldLettuce.IsEnabled = true;
            HoldLettuce.Opacity = 1;
            HoldLettuce.Visibility = Visibility.Visible;
            HoldJelly.Visibility = Visibility.Collapsed;
            HoldCheese.IsEnabled = true;
            HoldCheese.Opacity = 1;
            HoldCheese.Visibility = Visibility.Visible;
            HoldPickle.Visibility = Visibility.Collapsed;
            RemoveNugget.Visibility = Visibility.Collapsed;
        }

        private void OnHoldBunClicked(object sender, RoutedEventArgs args)
        {
            if(entree is Brontowurst bront)
            {
                bront.HoldBun();
            }
            else if(entree is SteakosaurusBurger steak)
            {
                steak.HoldBun();
            }
            else if(entree is TRexKingBurger king)
            {
                king.HoldBun();
            }
        }

        private void OnHoldKetchupClicked(object sender, RoutedEventArgs args)
        {
           if (entree is SteakosaurusBurger steak)
            {
                steak.HoldKetchup();
            }
            else if (entree is TRexKingBurger king)
            {
                king.HoldKetchup();
            }
        }

        private void OnAddNuggetClicked(object sender, RoutedEventArgs args)
        {
            if(entree is DinoNuggets nugs)
            {
                nugs.AddNugget();
            }
        }

        private void OnHoldMustardClicked(object sender, RoutedEventArgs args)
        {
            if (entree is SteakosaurusBurger steak)
            {
                steak.HoldMustard();
            }
            else if (entree is TRexKingBurger king)
            {
                king.HoldMustard();
            }
        }

        private void OnHoldPBClicked(object sender, RoutedEventArgs args)
        {
            if (entree is PrehistoricPBJ pbj)
            {
                pbj.HoldPeanutButter();
            }
        }

        private void OnHoldOnionClicked(object sender, RoutedEventArgs args)
        {
            if (entree is Brontowurst bronto)
            {
                bronto.HoldOnion();
            }
            else if (entree is TRexKingBurger king)
            {
                king.HoldOnion();
            }
        }

        private void OnHoldDressingClicked(object sender, RoutedEventArgs args)
        {
            if (entree is VelociWrap wrap)
            {
                wrap.HoldDressing();
            }
        }

        private void OnHoldPickleClicked(object sender, RoutedEventArgs args)
        {
            if (entree is TRexKingBurger king)
            {
                king.HoldPickle();
            }
            else if (entree is SteakosaurusBurger steak)
            {
                steak.HoldPickle();
            }
        }

        private void OnHoldJellyClicked(object sender, RoutedEventArgs args)
        {
            if (entree is PrehistoricPBJ pbj)
            {
                pbj.HoldJelly();
            }
        }

        private void OnHoldCheeseClicked(object sender, RoutedEventArgs args)
        {
            if (entree is VelociWrap velo)
            {
                velo.HoldCheese();
            }
        }

        private void OnRemoveNuggetClicked(object sender, RoutedEventArgs args)
        {
            if (entree is DinoNuggets nugs)
            {
                nugs.RemoveNugget();
            }
        }

        private void OnHoldLettuceClicked(object sender, RoutedEventArgs args)
        {
            if (entree is VelociWrap velo)
            {
                velo.HoldLettuce();
            }
            else if (entree is TRexKingBurger king)
            {
                king.HoldLettuce();
            }
        }

        private void OnHoldPeppersClicked(object sender, RoutedEventArgs args)
        {
            if (entree is Brontowurst bront)
            {
                bront.HoldPeppers();
            }
        }

        private void OnHoldTomatoClicked(object sender, RoutedEventArgs args)
        {
            if (entree is TRexKingBurger king)
            {
                king.HoldTomato();
            }
        }

        private void OnHoldMayoClicked(object sender, RoutedEventArgs args)
        {
            if (entree is TRexKingBurger king)
            {
                king.HoldMayo();
            }
        }
    }
}
