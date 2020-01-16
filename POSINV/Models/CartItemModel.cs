using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POSINV.Models
{
    public class CartItemModel : INotifyPropertyChanged
    {
        //backing field for Quantity
        private int quantity;

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

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

        public decimal Amount
        {
            get { return UnitPrice * Quantity; }
        }

        //event raised when a property is changed
        public event PropertyChangedEventHandler PropertyChanged;

        //Notifies consumers of change in property | set null for all properties
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
