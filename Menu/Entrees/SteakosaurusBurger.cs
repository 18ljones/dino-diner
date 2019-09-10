/*  SteakosaurusBurger.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class SteakosaurusBurger
    {
        /// <summary>
        /// Whether the bun is included in the Steakosaurus Burger
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether the pickles are included in the Steakosaurus Burger
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Whether the ketchup are included in the Steakosaurus Burger
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Whether the mustard are included in the Steakosaurus Burger
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// How much the Steakosaurus Burger costs
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// How many calories are in the Steakosaurus Burger
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// A list of the ingredients that are included in the current order of the Steakosaurus Burger
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole-Wheat Bun");
                if (pickle) ingredients.Add("Pickles");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
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
        }

        /// <summary>
        /// allows the user to not include the pickles with his/her Steakosaurus Burger
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// allows the user to not include the ketchup with his/her Steakosaurus Burger
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// allows the user to not include the mustard with his/her Steakosaurus Burger
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
