/*  CretaceousCombo.cs
 *  Author: Logan Jones
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class representing a Combo
    /// </summary>
    public class CretaceousCombo : MenuItem
    {
        private Entree entree;
        private Drink drink = new Sodasaurus();
        private Side side = new Fryceritops();

        /// <summary>
        /// property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// represents the Entree in the combo
        /// </summary>
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// represents the Drink in the combo
        /// </summary>
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// represents the Side in the combo
        /// </summary>
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// represents the toy in the combo
        /// </summary>
        public string Toy { get; private set; }

        /// <summary>
        /// repsents the total cost of the combo
        /// </summary>
        public override double Price
        {
            get
            {
                return (Entree.Price + Side.Price + Drink.Price) - 0.25;
            }
        }

        /// <summary>
        /// represents the total calories in the combo
        /// </summary>
        public override uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// represents all the ingredients used to make this combo
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }

        /// <summary>
        /// returns the description of this menu item
        /// </summary>
        /// <returns>the description</returns>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }

        /// <summary>
        /// returns the specials of this combo
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.ToString());
                special.AddRange(Side.Special);
                special.Add(Drink.ToString());
                special.AddRange(Drink.Special);
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }

        /// <summary>
        /// Default constructor for a CrestaceousCombo
        /// </summary>
        /// <param name="entree">the entree</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            this.Toy = "PS4";
        }

        /// <summary>
        /// Checks if properties have changed
        /// </summary>
        /// <param name="propertyName">name of the property</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
