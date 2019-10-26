/*  Order.cs
 *  Author: Logan Jones
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class for an order object
    /// </summary>
    public class Order : INotifyPropertyChanged
    {

        private double salesTaxRate;

        /// <summary>
        /// notifies when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets and sets the list of items in the order
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

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

        /// <summary>
        /// constructor for an order item
        /// </summary>
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            this.Items.CollectionChanged += this.OnCollectionChanged;
            salesTaxRate = 0.09;
        }

        /// <summary>
        /// OnCollectionChanged
        /// </summary>
        /// <param name="sender">the sender</param>
        /// <param name="args">event handler</param>
        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
