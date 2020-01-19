using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace POSINV.Models
{
    /// <summary>
    /// Describes a Sale IRL. Includes Misc Price and Sale Total
    /// </summary>
    public class SaleModel : INotifyPropertyChanged
    {
        //backing fields
        private decimal miscPrice;
        private decimal saleTotal;

        /// <summary>
        /// Unique integer ID for a sale
        /// </summary>
        public int SaleId { get; set; }

        /// <summary>
        /// DateTime of the sale processed
        /// </summary>
        public DateTime SaleDate { get; set; }

        /// <summary>
        /// Miscellaneous charges for items other than saved in inventory database
        /// </summary>
        public decimal MiscPrice
        {
            get
            {
                return miscPrice;
            }
            set
            {
                if (value != miscPrice)
                {
                    miscPrice = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Total charges of the sale including miscellaneous charges and cart items
        /// </summary>
        public decimal SaleTotal
        {
            get
            {
                return saleTotal;
            }
            set
            {
                if (value != saleTotal)
                {
                    saleTotal = value;
                    NotifyPropertyChanged();
                }
            }
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
