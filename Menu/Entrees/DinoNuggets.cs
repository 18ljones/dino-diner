/*  DinoNuggets.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing the Dino Nuggets menu item
    /// </summary>
    public class DinoNuggets : Entree, INotifyPropertyChanged
    {
        private uint nuggets = 6;

        /// <summary>
        /// property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// A list of the ingredients that are included in the current order of the Dino Nuggets
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                for(int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }


        /// <summary>
        /// returns special things about this order of dino nuggets
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(nuggets > 6)
                {
                    special.Add($"{nuggets - 6} Extra Nuggets");
                }
                return special.ToArray();
            }
        }

        /// <summary>
        /// returns the description of a dino nugget item
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
        /// returns the name of the menu item
        /// </summary>
        /// <returns>the name of the menu item</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }

        /// <summary>
        /// Creates a DinoNuggets object with the correct price and calories
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggets;
        }

        /// <summary>
        /// allows the user to add a nugget to their order for an extra $0.25 and updates the calories accordingly
        /// </summary>
        public void AddNugget()
        {
            nuggets++;
            Calories += 59;
            Price += .25;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Checks if properties have changed
        /// </summary>
        /// <param name="propertyName">name of the property</param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
