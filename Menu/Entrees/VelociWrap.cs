/*  VelociWrap.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class VelociWrap
    {
        /// <summary>
        /// Whether dressing is included in the Veloci-Wrap
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Whether the lettuce is included in the Veloci-Wrap
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether the cheese is included in the Veloci-Wrap
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// How much the Veloci-Wrap costs
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// How many calories are in the Veloci-Wrap
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// A list of the ingredients that are included in the current order of the Veloci-Wrap
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a Veloci-Wrap object with the correct price and calories
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }

        /// <summary>
        /// allows the user to not include dressing with his/her Veloci-Wrap
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }

        /// <summary>
        /// allows the user to not include the lettuce with his/her Veloci-Wrap
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }

        /// <summary>
        /// allows the user to not include the cheese with his/her Veloci-Wrap
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
    }
}
