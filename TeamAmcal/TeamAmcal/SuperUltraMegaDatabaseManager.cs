using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void AddSalesData(DateTime Date, int Quantity, int ProductNumber)
        {
            SalesData s = new SalesData(Date, Quantity);
            foreach (Product p in productList)
            {
                if (p.ProductNumber == ProductNumber)
                {
                    if (p.SaleData.Any())
                        s.SalesNumber = p.SaleData.ElementAt(p.SaleData.Count - 1).SalesNumber + 1;
                    else
                        s.SalesNumber = 0;
                    p.SaleData.Add(s);
                }
            }
            WriteData();
        }

        public void EditSalesData(DateTime Date, int Quantity, int ProductNumber, int SalesNumber)
        {
            ReadData();
            foreach (Product p in productList)
            {
                if (p.ProductNumber == ProductNumber)
                {
                    foreach (SalesData sd in p.SaleData)
                    {
                        if (sd.SalesNumber == SalesNumber)
                        {
                            sd.Date = Date;
                            sd.Quantity = Quantity;
                            break;
                        }
                    }
                }
            }
            WriteData();
        }

        public void DeleteSalesData(int ProductNumber, int SalesNumber)
        {
            ReadData();
            foreach (Product p in productList)
            {
                if (p.ProductNumber == ProductNumber)
                {
                    foreach (SalesData sd in p.SaleData)
                    {
                        if (sd.SalesNumber == SalesNumber)
                        {
                            p.SaleData.Remove(sd);
                            break;
                        }
                    }
                }
            }
            WriteData();
        }

        public float AddTotals(int ProductNumber)
        {
            ReadData();
            float total = 0;
            foreach (Product p in productList)
            {
                if (p.ProductNumber == ProductNumber)
                {
                    foreach (SalesData sd in p.SaleData)
                    {
                        total += p.Price * sd.Quantity;
                    }
                }
            }
            return total;
        }

        public List<Sale> YearlyReport(DateTime date)
        {
            List<Sale> result = new List<Sale>();       // A list of each product with the totals (Price, Quantity)

            float tSale = 0;
            int tQuantity = 0;

            foreach (Product p in productList)
            {
                foreach (SalesData sd in p.SaleData)
                {
                    if (sd.Date.Year == date.Year)
                    {
                        tSale += p.Price;
                        tQuantity += sd.Quantity;
                    }
                }
                // Creates new sale
                result.Add(new Sale(p.Name, tSale, tQuantity));
                // Resets variables
                tSale = 0;
                tQuantity = 0;
            }

            return result;
        }

        public List<Sale> MonthlyReport(DateTime date)
        {
            List<Sale> result = new List<Sale>();       // A list of each product with the totals (Price, Quantity)

            float tSale = 0;
            int tQuantity = 0;

            foreach (Product p in productList)
            {
                foreach (SalesData sd in p.SaleData)
                {
                    if (sd.Date.Year == date.Year && sd.Date.Month == date.Month)
                    {
                        tSale += p.Price;
                        tQuantity += sd.Quantity;
                    }
                }
                // Creates new sale
                result.Add(new Sale(p.Name, tSale, tQuantity));
                // Resets variables
                tSale = 0;
                tQuantity = 0;
            }

            return result;
        }

        // Simple linear regression in the form of y = a + bx
        // X = Date
        // Y = Quantity
        public DateTime LinearRegression(Product p)
        {
            // Variables
            int N = p.SaleData.Count;
            int sigmaX = 0;
            int sigmaY = 0;
            int sigmaXY = 0;
            int sigmaX2 = 0;
            List<int> dateX = new List<int>();

            // Results
            float gradient = 0;
            int intercept = p.Quantity;
            int xIsZero = 0;

            // Sets first data point to zero
            dateX.Add(0);

            // Calculation of sigmaY
            foreach (SalesData sd in p.SaleData)
            {
                sigmaY += sd.Quantity;
            }    

            // Calculation of sigmaX and sigmaX2
            for (int i = 0; i < N; i++)
            {
                DateTime d2 = p.SaleData[0].Date;
                DateTime d1 = p.SaleData[i].Date;

                int t = Convert.ToInt32((d1 - d2).TotalDays);
                dateX.Add(t);

                sigmaX += t;
                sigmaX2 += t * t;
            }

            // Calculation of sigma XY
            for (int i = 0; i < N; i++)
            {
                sigmaXY += p.SaleData[i].Quantity * dateX[i];
            }

            // Calculation of b (Gradient)
            gradient = (N * sigmaXY - (sigmaX * sigmaY)) / (N * sigmaX2 - (sigmaX * sigmaX));

            // When y = 0, x = -a/b
            xIsZero = Convert.ToInt32(-intercept / gradient);

            // Adds amount of days until stock is gone on current date
            DateTime result = p.SaleData[0].Date.AddDays(xIsZero);

            return result;
        }
    }
}