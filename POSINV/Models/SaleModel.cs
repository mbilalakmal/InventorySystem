using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSINV.Models
{
    /// <summary>
    /// Describes a Sale IRL. Includes Misc Price and Sale Total
    /// </summary>
    public class SaleModel
    {
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
        public decimal MiscPrice { get; set; }

        /// <summary>
        /// Total charges of the sale including miscellaneous charges and cart items
        /// </summary>
        public decimal SaleTotal { get; set; }
    }
}
