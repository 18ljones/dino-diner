using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract class that represents all Menu Items
    /// </summary>
    public abstract class MenuItem : IOrderItem
    {
        private double price;
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price 
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
                NotifyOfPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// gets the description of the item
        /// </summary>
        public abstract string Description { get; }
        /// <summary>
        /// gets the special condtions for the item
        /// </summary>
        public abstract string[] Special { get; }

        /// <summary>
        /// event handler for property changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

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
