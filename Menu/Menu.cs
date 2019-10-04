/* Menu.cs
 * Author: Logan Jones
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// public class for the Menu object
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// returns a list of every single item on the menu for Dino Diner
        /// </summary>
        public List<MenuItem> AvailableMenuItems
        {
            get
            {
                List<MenuItem> items = new List<MenuItem>();
                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());
                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());
                return items;
            }
        }

        /// <summary>
        /// returns a list of the available entrees
        /// </summary>
        public List<Entree> AvailableEntrees
        {
            get
            {
                List<Entree> items = new List<Entree>();
                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());
                return items;
            }
        }
        /// <summary>
        /// returns a list of the available sides
        /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> items = new List<Side>();
                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                return items;
            }
        }
        /// <summary>
        /// returns a list of the available drinks
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> items = new List<Drink>();
                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());
                return items;
            }
        }

        /// <summary>
        /// returns the whole menu in string format
        /// </summary>
        /// <returns>the whole menu in string format</returns>
        public override string ToString()
        {
            string menu = "";
            List<Entree> entrees = AvailableEntrees;
            List<Side> sides = AvailableSides;
            List<Drink> drinks = AvailableDrinks;
            for(int i = 0; i < entrees.Count; i++)
            {
                menu += entrees[i].ToString() + "\n";
            }
            for(int i = 0; i < sides.Count; i++)
            {
                menu += sides[i].ToString().Substring(6) + "\n";
            }
            for (int i = 0; i < sides.Count; i++)
            {
                menu += drinks[i].ToString().Substring(6) + "\n";
            }
            return menu;
        }

    }
}
