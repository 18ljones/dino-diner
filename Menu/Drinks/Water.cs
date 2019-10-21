using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// public class for Water
    /// </summary>
    public class Water : Drink
    {
        private Size size;

        /// <summary>
        /// specifies whether there is lemon
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// default constructor for water
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Lemon = false;
            Calories = 0;
            Price = 0.10;
        }
        /// <summary>
        /// Specifies the size
        /// </summary>
        public override Size Size
        {
            get
            {     
                return size;
            }
            set
            {
                NotifyOfPropertyChanged("Description");
                size = value;
            }
        }
        /// <summary>
        /// adds lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// returns the ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water" };
                if (Lemon) ingredients.Add("Lemon");
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
                if (Lemon) special.Add("Add Lemon");
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
            return Size.ToString() + " Water";
        }

    }
}
