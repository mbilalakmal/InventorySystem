using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSINV
{
    /// <summary>
    /// Describes a brand
    /// </summary>
    public class BrandModel
    {
        /// <summary>
        /// Unique integer ID for a brand
        /// </summary>
        public int BrandId { get; set; }

        /// <summary>
        /// Unique name for the brand
        /// </summary>
        public string BrandName { get; set; }
    }
}
