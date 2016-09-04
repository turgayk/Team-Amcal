using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class Product
    {
        public Product(string rKey, string rName, string rSupplier, int rQuantity, float rPrice, float rRRP, float rDiscounted)
        {
            Key = rKey;
            Name = rName;
            Supplier = rSupplier;
            Quantity = rQuantity;
            Price = rPrice;
            RRP = rRRP;
            Discounted = rDiscounted;
        }

        public string Key { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public float RRP { get; set; }
        public float Discounted { get; set; }
    }
}
