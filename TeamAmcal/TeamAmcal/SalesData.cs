using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class SalesData
    {
        public SalesData(DateTime rDate, int rQuantity)
        {
            Date = rDate;
            Quantity = rQuantity;
        }

        public int SalesNumber { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
    }
}
