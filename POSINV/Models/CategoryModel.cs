using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace POSINV
{
    /// <summary>
    /// Describes a category
    /// </summary>
    public class CategoryModel : INotifyPropertyChanged
    {
        //backing fields
        private string categoryName;

        /// <summary>
        /// Unique integer ID for a category
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Unique name for the category
        /// </summary>
        public string CategoryName
        {
            get
            {
                return categoryName;
            }
            set
            {
                if (value != categoryName)
                {
                    categoryName = value;
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
