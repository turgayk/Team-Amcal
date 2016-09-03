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

        public void LoadProducts()
        {
            using (StreamReader file = File.OpenText(Directory.GetCurrentDirectory() + "\\" + "Database.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Product p = (Product)serializer.Deserialize(file, typeof(Product));
                productList.Add(p);
            }
        }
    }
}
