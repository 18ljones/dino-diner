using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representing the Fryceritops Side menu item
    /// </summary>
    public class Fryceritops : Side
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
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
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
            return Size.ToString() + " Fryceritops";
        }

        /// <summary>
        /// Constructor for a Fryceritops Side menu item
        /// </summary>
        public Fryceritops()
        {
            base.Calories = 222;
            base.Price = 0.99;
        }
    }
}
