using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// base class for a drink menu item
    /// </summary>
    public abstract class Drink : MenuItem
    {
        /// <summary>
        /// gets and sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// gets and sets whether there is ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// sets ice to false
        /// </summary>
        public void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ice");
        }
    }
}
