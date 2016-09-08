using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace TeamAmcal
{
    class SuperUltraMegaDatabaseManager
    {
        private List<Product> productList = new List<Product>();

        //Products
        public void AddProduct(string Name, string Supplier, int Quantity, float Price, float RRP, float Discounted)
        {
            Product p = new Product(Name, Supplier, Quantity, Price, RRP, Discounted);

            if (!File.Exists(Directory.GetCurrentDirectory() + "Database" + ".json"))
            {
                p.Key = 0;
                productList.Add(p);
            }
            else
            {
                ReadProductData();

                p.Key = (productList.ElementAt(productList.Count - 1).Key + 1);
                productList.Add(p);
            }

            WriteProductData();
        }

        public void WriteProductData()
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "Database" + ".json", String.Empty);

            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "Database" + ".json");

            sw.Write(JsonConvert.SerializeObject(productList, Formatting.Indented));
            sw.Close();
        }

        public void ReadProductData()
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "Database" + ".json");
            if (!sr.EndOfStream)
                productList = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());

            sr.Close();
        }

        public void EditProductData(int Key, string Name, string Supplier, int Quantity, float Price, float RRP, float Discounted)
        {
            ReadProductData();

            foreach (Product p in productList)
            {
                if (p.Key == Key)
                {
                    p.Name = Name;
                    p.Supplier = Supplier;
                    p.Quantity = Quantity;
                    p.Price = Price;
                    p.RRP = RRP;
                    p.Discounted = Discounted;
                }
            }

            WriteSalesData();
        }

        public void DeleteProductData(string Product, int salesKey)
        {
            ReadSalesData();

            foreach (Product p in productList)
            {
                if (p.Name == Product)
                {
                    productList.Remove(p);
                    break;
                }
            }

            WriteSalesData();
        }

        //Sales
        public void AddSalesData(string Product, string Date, int Quantity, float Price, float Discounted, float Total)
        {
            SalesData s = new SalesData(Product, Date, Quantity, Price, Discounted, Total);

            foreach(Product p in productList)
            {
                if (Product == p.Name)
                {
                    if (p.SaleData.Any())
                        s.Key = p.SaleData.ElementAt(p.SaleData.Count - 1).Key + 1;
                    else
                        s.Key = 0;

                    p.SaleData.Add(s);
                }
            }

            WriteSalesData();
        }

        public void WriteSalesData()
        {
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "Database" + ".json");

            sw.Write(JsonConvert.SerializeObject(productList, Formatting.Indented));
            sw.Close();
        }

        public void ReadSalesData()
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "Database" + ".json");
            if (!sr.EndOfStream)
                productList = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());

            sr.Close();
        }

        public void EditSalesData(string Product, int salesKey, string Date, int Quantity, float Price, float Discounted, float Total)
        {
            ReadSalesData();

            foreach (Product p in productList)
            {
                if (p.Name == Product)
                {
                    foreach (SalesData sd in p.SaleData)
                    {
                        if (sd.Key == salesKey)
                        {
                            sd.Date = Date;
                            sd.Quantity = Quantity;
                            sd.Price = Price;
                            sd.Discounted = Discounted;
                            sd.Total = Total;
                            break;
                        }
                    }
                }
            }

            WriteSalesData();
        }
        
        public void DeleteSalesData(string Product, int salesKey)
        {
            ReadSalesData();

            foreach (Product p in productList)
            {
                if (p.Name == Product)
                {
                    foreach (SalesData sd in p.SaleData)
                    {
                        if (sd.Key == salesKey)
                        {
                            p.SaleData.Remove(sd);
                            break;
                        }
                    }
                }
            }

            WriteSalesData();
        }
        
        public float AddTotals(string Product)
        {
            ReadSalesData();

            float total = 0;

            foreach (Product p in productList)
            {
                if (p.Name == Product)
                {
                    foreach (SalesData sd in p.SaleData)
                    {
                        total += sd.Total;
                    }
                }
            }

            return total;
        }
    }
}
