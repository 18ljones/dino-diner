/*  Brontowurst.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        /// <summary>
        /// Whether the bun is included in the Brontowurst
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether the onions are included in the Brontowurst
        /// </summary>
        private bool onions = true;

        /// <summary>
        /// Whether the peppers are included in the Brontowurst
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// How much the Brontowurst costs
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// How many calories are in the Brontowurst
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// A list of the ingredients that are included in the current order of the Brontowurst
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onions");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a Brontowurst object with the correct price and calories
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        /// <summary>
        /// allows the user to not include a bun with his/her Brontowurst
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// allows the user to not include the peppers with his/her Brontowurst
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }

        /// <summary>
        /// allows the user to not include the onions with his/her Brontowurst
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
        }
    }
}
