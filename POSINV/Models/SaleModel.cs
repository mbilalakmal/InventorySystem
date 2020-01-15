using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSINV.Models
{
    public class SaleModel
    {
        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal MiscPrice { get; set; }
        public decimal SaleTotal { get; set; }
    }
}
