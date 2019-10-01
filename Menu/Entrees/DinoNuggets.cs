/*  DinoNuggets.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class representing the Dino Nuggets menu item
    /// </summary>
    public class DinoNuggets : Entree
    {
        private uint nuggets = 6;

        /// <summary>
        /// A list of the ingredients that are included in the current order of the Dino Nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a DinoNuggets object with the correct price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggets;
        }

        /// <summary>
        /// allows the user to add a nugget to their order for an extra $0.25 and updates the calories accordingly
        /// </summary>
        public void AddNugget()
        {
            nuggets++;
            Calories += 59;
            Price += .25;
        }
    }
}
