using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace POSINV
{
    /// <summary>
    /// Describes a brand
    /// </summary>
    public class BrandModel : INotifyPropertyChanged
    {
        //backing fields
        private string brandName;

        /// <summary>
        /// Unique integer ID for a brand
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// Unique name for the brand
        /// </summary>
        public string BrandName
        {
            get
            {
                return brandName;
            }
            set
            {
                if (value != brandName)
                {
                    brandName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Event for notifying changes in properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
