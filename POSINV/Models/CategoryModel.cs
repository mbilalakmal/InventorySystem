using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSINV
{
    /// <summary>
    /// Describes a category
    /// </summary>
    public class CategoryModel
    {
        /// <summary>
        /// Unique integer ID for a category
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Unique name for the category
        /// </summary>
        public string CategoryName { get; set; }
    }
}
