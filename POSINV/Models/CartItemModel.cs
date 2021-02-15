using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

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

        public string Description { get; set; }
        
        /// <summary>
        /// Cost price of a single product
        /// </summary>
        public decimal UnitCost { get; set; }

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
