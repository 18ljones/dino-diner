using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// represents a Sodasaurs drink object
    /// </summary>
    public class Sodasaurus : Drink
    {
        private Size size;
        private SodasaurusFlavor flavor;
        /// <summary>
        /// specifies the flavor
        /// </summary>
        public SodasaurusFlavor Flavor 
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// default constructor for Sodasaurus
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Flavor = SodasaurusFlavor.Cola;
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
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return Size.ToString() + " " + Flavor.ToString() + " Sodasaurus";
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
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }
    }
}
