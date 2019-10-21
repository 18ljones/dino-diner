using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for the Meteor Mac and Cheese Side menu item
    /// </summary>
    public class MeteorMacAndCheese : Side
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
                        Calories = 420;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        NotifyOfPropertyChanged("Price");
                        NotifyOfPropertyChanged("Calories");
                        NotifyOfPropertyChanged("Description");
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
                return new List<string>() { "Macaroni Noodles", "Cheese Product", "Pork Sausage" };
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
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return Size.ToString() + " Meteor Mac and Cheese";
        }

        /// <summary>
        /// Constructor for a Fryceritops Side menu item
        /// </summary>
        public MeteorMacAndCheese()
        {
            base.Calories = 420;
            base.Price = 0.99;
        }
    }
}
