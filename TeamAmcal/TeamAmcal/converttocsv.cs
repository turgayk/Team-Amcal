using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamAmcal
{
    class converttocsv
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

    }
}
