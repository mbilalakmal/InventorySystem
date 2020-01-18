using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POSINV
{
    /// <summary>
    /// Describes a product that can be sold. Includes cost, price, stock quantity
    /// </summary>
    public class ProductModel: INotifyPropertyChanged
    {
        //backing filed for Quantity
        private int quantity;

        /// <summary>
        /// Unique integer ID
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Unique name for the product
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Cost price of the product - Hidden from customer
        /// </summary>
        public decimal CostPrice { get; set; }

        /// <summary>
        /// Selling Price of the product - Included in Sale total and invoice
        /// </summary>
        public decimal ListPrice { get; set; }

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
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Optional description - Color, Size, Material
        /// </summary>
        public string Description { get; set; }
        
        /// <summary>
        /// Brand name of the product
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// Category name of the product
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Picture of the product represented in byte array
        /// </summary>
        public byte[] Picture { get; set; }

        //Converts image object of given format to byte array


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
            /// Convert byte[] to Image
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
