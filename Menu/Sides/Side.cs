using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// Enum representing the three sizes that a side can be
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// (0) represents the small Side size
        /// </summary>
        Small,
        /// <summary>
        /// (1) represents the medium Side size
        /// </summary>
        Medium, 
        /// <summary>
        /// (2) represents the Large Side size
        /// </summary>
        Large
    }

    /// <summary>
    /// Abstract class representing all Side menu items
    /// </summary>
    public abstract class Side : MenuItem
    {
        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
    }
}
