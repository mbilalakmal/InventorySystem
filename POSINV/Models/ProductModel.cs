using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;

namespace POSINV
{
    /// <summary>
    /// Describes a product that can be sold. Includes cost, price, stock quantity
    /// </summary>
    public class ProductModel: INotifyPropertyChanged
    {
        //backing fields
        private string sku;
        private string productName;
        private decimal costPrice;
        private decimal listPrice;
        private int quantity;
        private DateTime updatedOn;
        private string description;
        private string brandName;
        private string categoryName;
        private byte[] picture;

        /// <summary>
        /// Unique integer ID
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Stock keeping unit for a product - Similar to barcode
        /// </summary>
        public string SKU
        {
            get
            {
                return sku;
            }
            set 
            {
                if(value != sku)
                {
                    sku = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Unique name for the product
        /// </summary>
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                if (value != productName)
                {
                    productName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Cost price of the product - Hidden from customer
        /// </summary>
        public decimal CostPrice
        {
            get
            {
                return costPrice;
            }
            set
            {
                if (value != costPrice)
                {
                    costPrice = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Selling Price of the product - Included in Sale total and invoice
        /// </summary>
        public decimal ListPrice
        {
            get
            {
                return listPrice;
            }
            set
            {
                if (value != listPrice)
                {
                    listPrice = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Quantity available in stock
        /// </summary>
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (value != quantity)
                {
                    quantity = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// DateTime of last stock update
        /// </summary>
        public DateTime UpdatedOn
        {
            get
            {
                return updatedOn;
            }
            set
            {
                if (value != updatedOn)
                {
                    updatedOn = value;
                    NotifyPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Optional description - Color, Size, Material
        /// </summary>
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value != description)
                {
                    description = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        /// <summary>
        /// Brand name of the product
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
        /// Category name of the product
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
        /// Picture of the product represented in byte array
        /// </summary>
        public byte[] Picture
        {
            get
            {
                return picture;
            }
            set
            {
                if (value != picture)
                {
                    picture = value;
                    NotifyPropertyChanged();
                }
            }
        }
        
        /// <summary>
        /// Accepts an image in a given format and returns a byte array created from the image
        /// </summary>
        public static byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            if(image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        /// <summary>
        /// Accepts byte array and returns an image created from the byte array
        /// </summary>
        /// <param name="imageBytes"></param>
        /// <returns></returns>
        public static Image ByteToImage(byte[] imageBytes)
        {
            if(imageBytes == null)
            {
                return null;
            }
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
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
