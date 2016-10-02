using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class SalesData
    {
        public SalesData(string rDate, int rQuantity)
        {
            Date = rDate;
            Quantity = rQuantity;
        }

        public int SalesNumber { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
    }
}
