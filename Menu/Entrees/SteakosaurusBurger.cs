/*  SteakosaurusBurger.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing the Steakosaurus Burger menu item
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        private bool bun = true;

        private bool pickle = true;

        private bool ketchup = true;

        private bool mustard = true;

        /// <summary>
        /// A list of the ingredients that are included in the current order of the Steakosaurus Burger
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
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
        /// returns special things about this menu item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return "Steakosaurus Burger";
        }

        /// <summary>
        /// Creates a SteakosaurusBurger object with the correct price and calories
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// allows the user to not include a bun with his/her Steakosaurus Burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// allows the user to not include the pickles with his/her Steakosaurus Burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// allows the user to not include the ketchup with his/her Steakosaurus Burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// allows the user to not include the mustard with his/her Steakosaurus Burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }
    }
}
