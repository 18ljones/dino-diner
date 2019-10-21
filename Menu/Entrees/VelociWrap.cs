/*  VelociWrap.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing the Velociwrap menu item
    /// </summary>
    public class VelociWrap : Entree
    {
        private bool dressing = true;

        private bool lettuce = true;

        private bool cheese = true;

        /// <summary>
        /// A list of the ingredients that are included in the current order of the Veloci-Wrap
        /// </summary>
        public override List<string> Ingredients
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
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
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
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// allows the user to not include the lettuce with his/her Veloci-Wrap
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// allows the user to not include the cheese with his/her Veloci-Wrap
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }
    }
}
