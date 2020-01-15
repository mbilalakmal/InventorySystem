using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSINV.Models
{
    public class CartItemModel
    {
        public ProductModel product { get; set; }
        public int productQuantity { get; set; }
    }
}
