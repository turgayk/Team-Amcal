using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class SalesData
    {
        public SalesData(DateTime rDate, int rQuantity, float rPrice, float rDiscounted, float rTotal)
        {
            Date = rDate;
            Quantity = rQuantity;
            Price = rPrice;
            Discounted = rDiscounted;
            Total = rTotal;
        }

        public int Key { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Discounted { get; set; }
        public float Total { get; set; }
    }
}
