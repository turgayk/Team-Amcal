﻿using System;
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

        /// <summary>
        /// If a file with a matching key does not exist, a new product is created.
        /// </summary>
        public void CreateProduct(string Key, string Name, string Supplier, int Quantity, float Price, float RRP, float Discounted)
        {
            Product p = new Product(Key, Name, Supplier, Quantity, Price, RRP, Discounted);
            productList.Add(p);
            if (!File.Exists(Directory.GetCurrentDirectory() + Key + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + Key + ".json"))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, p);
                }
            }
        }

        public void AddSale(DateTime yyyymmdd, float soldFor, Product p)
        {
            foreach (Product pr in productList)
            {
                if (pr == p)
                {
                    pr.SaleDate.Add(yyyymmdd);
                    pr.SalePrice.Add(soldFor);
                    if (File.Exists(Directory.GetCurrentDirectory() + pr.Key + ".json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + pr.Key + ".json"))
                        using (JsonWriter writer = new JsonTextWriter(sw))
                        {
                            serializer.Serialize(writer, pr);
                        }
                    }
                }
            }
        }
    }
}