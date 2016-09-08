using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
/*
namespace TeamAmcal
{
    class Sales
    {
        private List<SalesData> salesList= new List<SalesData>();

        public void AddSalesData(string Product, string Date, int Quantity, float Price, float Discounted, float Total)
        {
            SalesData s = new SalesData(Product, Date, Quantity, Price, Discounted, Total);

            if (!File.Exists(Directory.GetCurrentDirectory() + Product + "_Sales" + ".json"))
            {
                s.Key = 0;
                salesList.Add(s);

                WriteSalesData(Product);
            }
            else
            {
                ReadSalesData(Product);

                s.Key = salesList.ElementAt(salesList.Count - 1).Key + 1;
                salesList.Add(s);

                File.WriteAllText(Directory.GetCurrentDirectory() + Product + "_Sales" + ".json", String.Empty);

                WriteSalesData(Product);
            }
        }

        public void WriteSalesData(string Product)
        {
            StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + Product + "_Sales" + ".json");

            sw.Write(JsonConvert.SerializeObject(salesList, Formatting.Indented));
            sw.Close();
        }

        public void ReadSalesData(string Product)
        {
            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + Product + "_Sales" + ".json");
            if (!sr.EndOfStream)
                salesList = JsonConvert.DeserializeObject<List<SalesData>>(sr.ReadToEnd());

            sr.Close();
        }

        public void EditSalesData(int Key, string Product, string Date, int Quantity, float Price, float Discounted, float Total)
        {
            ReadSalesData(Product);

            foreach (SalesData sd in salesList)
            {
                if (sd.Key == Key)
                {
                    sd.Date = Date;
                    sd.Quantity = Quantity;
                    sd.Price = Price;
                    sd.Discounted = Discounted;
                    sd.Total = Total;
                    break;
                }
            }

            WriteSalesData(Product);
        }

        public void DeleteSalesData(int Key, string Product)
        {
            ReadSalesData(Product);

            foreach (SalesData sd in salesList)
            {
                if (sd.Key == Key)
                {
                    salesList.Remove(sd);
                    break;
                }
            }

            WriteSalesData(Product);
        }

        public float AddTotals(string Product)
        {
            ReadSalesData(Product);

            float total = 0;

            foreach (SalesData sd in salesList)
            {
                total += sd.Total;
            }

            return total;
        }
    }
}
*/