using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for the Triceritots Side menu item
    /// </summary>
    public class Triceritots : Side
    {
        private Size size;
        /// <summary>
        /// Gets and sets the size
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// gets the list of ingrediants
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                return new List<string>() { "Potato", "Salt", "Vegtable Oil" };
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return Size.ToString() + " Triceritots";
        }

        /// <summary>
        /// Constructor for a Fryceritops Side menu item
        /// </summary>
        public Triceritots()
        {
            base.Calories = 352;
            base.Price = 0.99;
        }
    }
}
