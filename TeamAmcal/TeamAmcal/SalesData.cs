using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class SalesData
    {
        public SalesData(string rDate, int rQuantity, float rPrice, float rDiscounted, float rSoldFor)
        {
            Date = rDate;
            Quantity = rQuantity;
            Price = rPrice;
            Discounted = rDiscounted;
            SoldFor = rSoldFor;
        }

        public int Key { get; set; }
        public string Date { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float Discounted { get; set; }
        public float SoldFor { get; set; }
    }
}
