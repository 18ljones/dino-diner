/*  TRexKingBurger.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class TRexKingBurger
    {
        /// <summary>
        /// Whether the bun is included in the T-Rex King Burger
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether the lettuce is included in the T-Rex King Burger
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether the tomato is included in the T-Rex King Burger
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Whether the onion is included in the T-Rex King Burger
        /// </summary>
        private bool onion = true;

        /// <summary>
        /// Whether the pickles are included in the T-Rex King Burger
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Whether the ketchup are included in the T-Rex King Burger
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Whether the mustard are included in the T-Rex King Burger
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// Whether the mayo is included in the T-Rex King Burger
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// How much the T-Rex King Burger costs
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// How many calories are in the T-Rex King Burger
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// A list of the ingredients that are included in the current order of the T-Rex King Burger
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a TRexKingBurger object with the correct price and calories
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }

        /// <summary>
        /// allows the user to not include a bun with his/her T-Rex King Burger
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// allows the user to not include lettuce with his/her T-Rex King Burger
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// allows the user to not include tomato with his/her T-Rex King Burger
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }

        /// <summary>
        /// allows the user to not include onion with his/her T-Rex King Burger
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }

        /// <summary>
        /// allows the user to not include the pickles with his/her T-Rex King Burger
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

        /// <summary>
        /// allows the user to not include mayo with his/her T-Rex King Burger
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
    }
}
