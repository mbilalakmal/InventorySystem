using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POSINV.Models
{
    /// <summary>
    /// Describes an item in cart. Includes unit price and quantity
    /// </summary>
    public class CartItemModel : INotifyPropertyChanged
    {
        //backing field for Quantity
        private int quantity;

        /// <summary>
        /// Unique integer ID
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Unique name of the product
        /// </summary>
        public string ProductName { get; set; }
        
        /// <summary>
        /// List price of a single product
        /// </summary>
        public decimal UnitPrice { get; set; }


        /// <summary>
        /// Natural number indicating quantity purchased in a single sale
        /// </summary>
        public int Quantity
        {
            get
            {
                return this.quantity;
            }
            set
            {
                if (value != this.quantity)
                {
                    this.quantity = value;
                    NotifyPropertyChanged();
                    NotifyPropertyChanged("Amount");
                }
            }
        }

        /// <summary>
        /// Derived property calculated by multiplying quantity and unit price
        /// </summary>
        public decimal Amount
        {
            get { return UnitPrice * Quantity; }
        }

        /// <summary>
        /// Event raised when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        //Notifies consumers of change in property | set null for all properties
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
