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


            //Testing
            Sales s = new Sales();
            //s.AddSalesData("testProduct", "testDate", 10, 10, 10, 10);

            for (int i = 0; i < 10; i++)
                s.AddSalesData("testProduct", "testDate2", 5, 5, 5, 5);

            //s.AddTotals("testKey");
        }
    }
}
