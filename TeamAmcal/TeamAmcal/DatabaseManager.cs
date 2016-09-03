using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TeamAmcal
{
    class DatabaseManager
    {
        private List<Product> productList = new List<Product>();

        /// <summary>
        /// Reads .json files and creates and adds new products to the list.
        /// </summary>
        public void LoadProducts()
        {
            foreach (string file in Directory.EnumerateFiles(Directory.GetCurrentDirectory(), "*.json"))
            {
                using (StreamReader file_2 = File.OpenText(file))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    Product p = (Product)serializer.Deserialize(file_2, typeof(Product));
                    productList.Add(p);
                }
            }
        }
    }
}
