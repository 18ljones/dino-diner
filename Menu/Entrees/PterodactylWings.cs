/*  PterodactylWings.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class representing the Prerodactyl Wings menu item
    /// </summary>
    public class PterodactylWings : MenuItem
    {
        /// <summary>
        /// A list of the ingredients that are included in the current order of the Pterodactyl Wings
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        /// <summary>
        /// Creates a PterodactylWings object with the correct price and calories
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
    }
}
