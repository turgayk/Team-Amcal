using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class Sale
    {
        public Sale (string name, float price, DateTime date)
        {
            Name = name;
            Price = price;
            Date = date;
        }

        string Name { get; set; }
        float Price { get; set; }
        DateTime Date { get; set; }
    }
}
