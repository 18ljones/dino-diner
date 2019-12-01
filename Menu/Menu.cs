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
        /// returns a list of all menu items including combos
        /// </summary>
        public List<MenuItem> AllMenuItems
        {
            get
            {
                List<MenuItem> items = new List<MenuItem>();
                items.AddRange(AvailableCombos);
                items.AddRange(AvailableMenuItems);
                return items;
            }
        }

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
        /// returns a list of the available combos
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> items = new List<CretaceousCombo>();
                items.Add(new CretaceousCombo(new Brontowurst()));
                items.Add(new CretaceousCombo(new DinoNuggets()));
                items.Add(new CretaceousCombo(new PrehistoricPBJ()));
                items.Add(new CretaceousCombo(new PterodactylWings()));
                items.Add(new CretaceousCombo(new SteakosaurusBurger()));
                items.Add(new CretaceousCombo(new TRexKingBurger()));
                items.Add(new CretaceousCombo(new VelociWrap()));
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
                items.Add(new Fryceritops());
                items.Add(new Fryceritops(Size.Large));
                items.Add(new MeteorMacAndCheese());
                items.Add(new MeteorMacAndCheese(Size.Medium));
                items.Add(new MeteorMacAndCheese(Size.Large));
                items.Add(new MezzorellaSticks());
                items.Add(new MezzorellaSticks(Size.Medium));
                items.Add(new MezzorellaSticks(Size.Large));
                items.Add(new Triceritots());
                items.Add(new Triceritots(Size.Medium));
                items.Add(new Triceritots(Size.Large));
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

        /// <summary>
        /// returns all possible ingredients
        /// </summary>
        public HashSet<string> PossibleIngredients
        {
            get
            {
                HashSet<string> ingredients = new HashSet<string>();
                for (int i = 0; i < this.AvailableMenuItems.Count; i++)
                {
                    for(int j = 0; j < AvailableMenuItems[i].Ingredients.Count; j++)
                    {
                        if (!ingredients.Contains(AvailableMenuItems[i].Ingredients[j]))
                        {
                            ingredients.Add(AvailableMenuItems[i].Ingredients[j]);
                        }
                    }
                }
                return ingredients;
            }
        }

        /// <summary>
        /// allows user to search for specific menu items
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public static List<MenuItem> OnSearch(List<MenuItem> menuItems, string search)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (MenuItem j in menuItems)
            {
                if (j.ToString().ToLower().Contains(search.ToLower()))
                {
                    items.Add(j);
                }
            }

            return items;
        }

        /// <summary>
        /// yes
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="filters"></param>
        /// <returns></returns>
        public static List<MenuItem> OnCategoryFilter(List<MenuItem> menuItems, List<string> filters)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (MenuItem j in menuItems)
            {
                if (filters.Contains("Combo"))
                {
                    if (j is CretaceousCombo combo)
                    {
                        items.Add(combo);
                    }
                }
                if (filters.Contains("Entree"))
                {
                    if (j is Entree entree)
                    {
                        items.Add(entree);
                    }
                }
                if (filters.Contains("Side"))
                {
                    if(j is Side side)
                    {
                        items.Add(side);
                    }
                }
                if (filters.Contains("Drink"))
                {
                    if(j is Drink drink)
                    {
                        items.Add(drink);
                    }
                }
            }

            return items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static List<MenuItem> OnPriceFilter(List<MenuItem> menuItems, float min, float max)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach(MenuItem j in menuItems)
            {
                if (j.Price >= min && j.Price <= max)
                    items.Add(j);
            }

            return items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="min"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static List<MenuItem> OnPriceFilter(List<MenuItem> menuItems, float min, string s)
        {
            List<MenuItem> items = new List<MenuItem>();

            foreach (MenuItem j in menuItems)
            {
                if (s == "min") {
                    if (j.Price >= min)
                        items.Add(j);
                }
                else if(s == "max")
                {
                    if (j.Price <= min)
                        items.Add(j);
                }
            }

            return items;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="menuItems"></param>
        /// <param name="ingredients"></param>
        /// <returns></returns>
        public static List<MenuItem> OnIngredientFilter(List<MenuItem> menuItems, List<string> ingredients)
        {
            List<MenuItem> items = new List<MenuItem>();


            bool isGood = true;
            foreach(MenuItem j in menuItems)
            {
                foreach(string ing in ingredients)
                {
                    if (j.Ingredients.Contains(ing))
                    {
                        isGood = false;
                        break;
                    }
                }
                if (isGood)
                    items.Add(j);
                else
                {
                    isGood = true;
                }
            }

            return items;
        }

    }
}
