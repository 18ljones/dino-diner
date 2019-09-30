using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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
                size = value;
            }
        }
        /// <summary>
        /// adds lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
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
    }
}
