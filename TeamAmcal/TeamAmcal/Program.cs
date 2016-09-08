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

            //sumdm.AddProduct("testProduct2", "test", 1, 1, 1, 1);
            //for (int i = 10; i < 15; i++)
            //    sumdm.AddSalesData("testProduct", "testDate", i, i, i, i);

            //sumdm.EditSalesData("testProduct", 10, "NEWDATE", 55, 55, 55, 55);

            //sumdm.DeleteSalesData("testProduct", 5);
        }
    }
}
