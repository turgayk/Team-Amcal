using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class Sale
    {
        public Sale(string name, float price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        string Name { get; set; }
        float Price { get; set; }
        int Quantity { get; set; }
    }
}
