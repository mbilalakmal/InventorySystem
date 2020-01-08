using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSINV
{
    public class ProductModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ListPrice { get; set; }
        public decimal CostPrice { get; set; }
        public int Quantity { get; set; }

        public DateTime UpdatedOn { get; set; }
        public string Description { get; set; }

        //public int BrandId { get; set; }
        public string BrandName { get; set; }
        //public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        //picture
        public byte[] Picture { get; set; }

        //Converts image object of given format to byte array


        /// <summary>Accepts an image in a given format and returns a byte array created from image</summary>
        public static byte[] ImageToByte(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return imageBytes;
            }
        }

        public static Image ByteToImage(byte[] imageBytes)
        {
            /// Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
    }

}
