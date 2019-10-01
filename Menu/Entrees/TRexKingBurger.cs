/*  TRexKingBurger.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class representing the T-Rex King Burger menu item
    /// </summary>
    public class TRexKingBurger : Entree
    {
        private bool bun = true;

        private bool lettuce = true;

        private bool tomato = true;

        private bool onion = true;

        private bool pickle = true;

        private bool ketchup = true;

        private bool mustard = true;

        private bool mayo = true;

        /// <summary>
        /// A list of the ingredients that are included in the current order of the T-Rex King Burger
        /// </summary>
        public override List<string> Ingredients
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
