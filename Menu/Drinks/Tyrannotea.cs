using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// class for Tyrannotea
    /// </summary>
    public class Tyrannotea : Drink
    {
        private Size size;
        private bool sweet;
        private bool lemon;

        /// <summary>
        /// specifies whether it is sweet or not
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                switch (sweet)
                {
                    case true:
                        if (Size == Size.Small) Calories = 16;
                        else if (Size == Size.Medium) Calories = 32;
                        else Calories = 64;
                        break;
                    case false:
                        if (Size == Size.Small) Calories = 8;
                        else if (Size == Size.Medium) Calories = 16;
                        else Calories = 32;
                        break;
                }
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// specifies whether there is lemon or not
        /// </summary>
        public bool Lemon 
        {
            get
            {
                return lemon;
            }
            set 
            {
                lemon = value;
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Ingredients");
            }
        }

        /// <summary>
        /// default constructor for Tyrannotea
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Sweet = false;
            Lemon = false;
        }
        /// <summary>
        /// gets and sets the size, as well as changes the calories and price accordingly
        /// </summary>
        public override Size Size {
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
                        if (Sweet) Calories = 16;
                        else Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        if (Sweet) Calories = 32;
                        else Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        if (Sweet) Calories = 64;
                        else Calories = 32;
                        break;
                }
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }
        /// <summary>
        /// returns the list of ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Water", "Tea" };
                if (Lemon) ingredients.Add("Lemon");
                if (Sweet) ingredients.Add("Cane Sugar");
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
            if(Sweet) return Size.ToString() + " Sweet Tyrannotea";
            else return Size.ToString() + " Tyrannotea";
        }

        /// <summary>
        /// adds lemon
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
        /// <summary>
        /// updates the calories when sweetener is added or removed
        /// </summary>
        public void updateCals()
        {

        }
    }
}
