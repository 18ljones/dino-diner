/*  IOrderItem.cs
 *  Author: Logan Jones
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// specifies 3 methods that are used by an order item
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// gets the price of the order item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// gets the description of an order item
        /// </summary>
        string Description { get; }
        /// <summary>
        /// gets the special conditions for this order item
        /// </summary>
        string[] Special { get; }
    }
}
