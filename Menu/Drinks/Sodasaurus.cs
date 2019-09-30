using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// represents a Sodasaurs drink object
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size size;
        /// <summary>
        /// specifies the flavor
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }

        /// <summary>
        /// default constructor for Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
        }
        /// <summary>
        /// returns the ingredients of sodasaurs
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<String>() { "Water", "Natural Flavors", "Cane Sugar" };
                return ingredients;
            }
        }

        /// <summary>
        /// gets and sets the size, as well as changes the calories and price accordingly
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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
            }
        }
    }
}
