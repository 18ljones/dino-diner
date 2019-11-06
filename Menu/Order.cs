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
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// notifies when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// gets and sets the list of items in the order
        /// </summary>
        public IOrderItem[] Items { get { return items.ToArray(); } }

        /// <summary>
        /// adds an item to the list of items
        /// </summary>
        /// <param name="item">the item being added</param>
        public void Add(IOrderItem item)
        {
            item.PropertyChanged += OnItemPropertyChanged;
            items.Add(item);
            NotifyPropertyChanged("Items");
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
        }
        
        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        /// <returns>whether the item was able to be removed</returns>
        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed)
            {
                NotifyPropertyChanged("Items");
                NotifyPropertyChanged("SubtotalCost");
                NotifyPropertyChanged("SalesTaxCost");
                NotifyPropertyChanged("TotalCost");
            }
            return removed;
        }

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

        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            NotifyPropertyChanged("SubtotalCost");
            NotifyPropertyChanged("SalesTaxCost");
            NotifyPropertyChanged("TotalCost");
            NotifyPropertyChanged("Items");
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
