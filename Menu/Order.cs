/*  Order.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for an order object
    /// </summary>
    public class Order
    {

        private double salesTaxRate = 0.09;

        /// <summary>
        /// gets and sets the list of items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();

        /// <summary>
        /// gets and sets the subtotal cost
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotalCost = 0.00;
                foreach(IOrderItem x in Items)
                {
                    subtotalCost += x.Price;
                }
                if (subtotalCost < 0.00) return 0.00;
                else return subtotalCost;
            }
        }

        /// <summary>
        /// gets and sets the sales tax rate
        /// </summary>
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            protected set
            {
                salesTaxRate = value;
            }
        }

        /// <summary>
        /// gets and sets the sales tax cost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SubtotalCost * SalesTaxRate;
            }
        }

        /// <summary>
        /// gets and sets the total cost
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SalesTaxCost + SubtotalCost;
            }
        }
    }
}
