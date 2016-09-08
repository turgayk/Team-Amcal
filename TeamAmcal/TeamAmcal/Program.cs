using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamAmcal
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            SuperUltraMegaDatabaseManager sumdm = new SuperUltraMegaDatabaseManager();

            sumdm.AddProduct("testProduct1", "test", 1, 1, 1, 1);

            sumdm.AddProduct("testProduct2", "test", 1, 1, 1, 1);

            for (int i = 0; i < 15; i++)
                sumdm.AddSalesData(1, "testDate", i, i, i, i);

            sumdm.EditSalesData(1, 10, "NEWDATE", 55, 55, 55, 55);

            sumdm.DeleteSalesData(1, 5);

            sumdm.AddProduct("testProduct3", "test", 1, 1, 1, 1);

            sumdm.DeleteProductData(0);
        }
    }
}
