using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class accessingtextfile
    {
        public void texttocsv()
        {
            string[] lines = System.IO.File.ReadAllLines("YOUR INPUT FILE");
            StringBuilder builder = new StringBuilder();
            foreach (string line in lines)
            {
                var temp = line.Split('\t');
                builder.AppendLine(string.Join(",", temp[0], temp[1]));
                //builder.AppendLine(string.Format("{0}; {1}", temp[0], temp[1]));
            }

            System.IO.File.WriteAllText("", builder.ToString());

        }

        static void Main()
        {
            // Read each line of the file into a string array. Each element
            // of the array is one line of the file.
            string[] lines = System.IO.File.ReadAllLines(@"");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();

        }
    }
}
