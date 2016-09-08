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

        public void WriteData()
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "Database" + ".json", String.Empty);

            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "Database" + ".json");

            sw.Write(JsonConvert.SerializeObject(productList, Formatting.Indented));
            sw.Close();
        }

        public void ReadData()
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "Database" + ".json");
            if (!sr.EndOfStream)
                productList = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());

            sr.Close();
        }

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
                ReadData();

                p.Key = (productList.ElementAt(productList.Count - 1).Key + 1);
                productList.Add(p);
            }

            WriteData();
        }

        public void EditProductData(int Key, string Name, string Supplier, int Quantity, float Price, float RRP, float Discounted)
        {
            ReadData();

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

            WriteData();
        }

        public void DeleteProductData(int Key)
        {
            ReadData();

            foreach (Product p in productList)
            {
                if (p.Key == Key)
                {
                    productList.Remove(p);
                    break;
                }
            }

            WriteData();
        }

        //Sales
        public void AddSalesData(int productKey, string Date, int Quantity, float Price, float Discounted, float Total)
        {
            SalesData s = new SalesData(Date, Quantity, Price, Discounted, Total);

            foreach(Product p in productList)
            {
                if (p.Key == productKey)
                {
                    if (p.SaleData.Any())
                        s.Key = p.SaleData.ElementAt(p.SaleData.Count - 1).Key + 1;
                    else
                        s.Key = 0;

                    p.SaleData.Add(s);
                }
            }

            WriteData();
        }

        public void EditSalesData(int productKey, int salesKey, string Date, int Quantity, float Price, float Discounted, float Total)
        {
            ReadData();

            foreach (Product p in productList)
            {
                if (p.Key == productKey)
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

            WriteData();
        }
        
        public void DeleteSalesData(int productKey, int salesKey)
        {
            ReadData();

            foreach (Product p in productList)
            {
                if (p.Key == productKey)
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

            WriteData();
        }
        
        public float AddTotals(int Key)
        {
            ReadData();

            float total = 0;

            foreach (Product p in productList)
            {
                if (p.Key == Key)
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
