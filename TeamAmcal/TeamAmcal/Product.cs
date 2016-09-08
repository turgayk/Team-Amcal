using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class Product
    {
        public Product(string rName, string rSupplier, int rQuantity, float rPrice, float rRRP, float rDiscounted)
        {
            Name = rName;
            Supplier = rSupplier;
            Quantity = rQuantity;
            Price = rPrice;
            RRP = rRRP;
            Discounted = rDiscounted;

            SaleData = new List<SalesData>();
        }

        public int Key { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float RRP { get; set; }
        public float Discounted { get; set; }
        public List<SalesData> SaleData { get; set; }
    }
}
