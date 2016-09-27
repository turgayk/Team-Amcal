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

        public List<Product> ProductList
        {
            get
            {
                return productList;
            } // end get
        } // end ProductList

        public Product getProduct(int aIndex)
        {
            if (aIndex < 0 || aIndex >= productList.Count)
                return null;
            else
                return productList[aIndex];
        } // end getProduct

        public void WriteData()
        {
            File.WriteAllText(Directory.GetCurrentDirectory() + "Database" + ".json", String.Empty);

            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "Database" + ".json");

            sw.Write(JsonConvert.SerializeObject(productList, Formatting.Indented));
            sw.Close();
        }

        public void ReadData()
        {
            string current = Directory.GetCurrentDirectory();
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "Database" + ".json");

            if (!sr.EndOfStream)
                productList = JsonConvert.DeserializeObject<List<Product>>(sr.ReadToEnd());

            sr.Close();
        }

        //Products
        public void AddProduct(string aKey, string Name, string Supplier, int Quantity, float Price, float RRP, float Discounted)
        {
            Product p = new Product(aKey, Name, Supplier, Quantity, Price, RRP, Discounted);

            if (!File.Exists(Directory.GetCurrentDirectory() + "Database" + ".json"))
            {
                p.ProductNumber = 0;
                productList.Add(p);
            }
            else
            {
                ReadData();
                if (ProductList.Count != 0)
                    p.ProductNumber = (productList.ElementAt(productList.Count - 1).ProductNumber + 1);
                else
                    p.ProductNumber = 0;
                productList.Add(p);
            }

            WriteData();
        }

        public void EditProductData(string Key, string Name, string Supplier, int Quantity, float Price, float RRP, float Discounted)
        {
            ReadData();

            foreach (Product p in productList)
            {
                if (p.Key == Key)
                {
                    if (Name != "")
                        p.Name = Name;
                    if (Supplier != "")
                        p.Supplier = Supplier;
                    if (Quantity != -1)
                        p.Quantity = Quantity;
                    if (Price != -1.0)
                        p.Price = Price;
                    if (RRP != -1.0)
                        p.RRP = RRP;
                    if (Discounted != -1)
                        p.Discounted = Discounted;
                }
            }

            WriteData();
        }

        public void DeleteProductData(int ProductNumber)
        {
            ReadData();

            foreach (Product p in productList)
            {
                if (p.ProductNumber == ProductNumber)
                {
                    productList.Remove(p);
                    break;
                }
            }

            WriteData();
        }

        //Sales
        /*public void AddSalesData(int productKey, string Date, int Quantity, float Price, float Discounted, float Total)
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
        }*/

        /*public void EditSalesData(string productKey, int salesKey, string Date, int Quantity, float Price, float Discounted, float Total)
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
        }*/
        
        /*public void DeleteSalesData(string productKey, int salesKey)
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
        }*/
        
        /*public float AddTotals(string Key)
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
        }*/
    }
}
