/*  PterodactylWings.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing the Prerodactyl Wings menu item
    /// </summary>
    public class PterodactylWings : Entree
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
        /// gets the description of this item
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// returns special things about this order item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return "Pterodactyl Wings";
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
