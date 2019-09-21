using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public static class DataManager
    {
        /// <summary>
        /// Fetching data from local db(.txt)
        /// </summary>
        /// <returns>Returns a List<Data>.</returns>
        public static List<Data> GetData()
        {
            //If file exists split and assign the data to each list
            if (File.Exists(@"data.txt"))
            {
                var arr = File.ReadAllLines(@"data.txt");
                string[] split;
                List<Data> output = new List<Data>();
                int c = 0;
                foreach (var line in arr)
                {
                    c++;
                    //spliting
                    split = line.Split('|');
                    //assigning
                    output.Add(new Data() { Id = c , StartDate = split[0], EndDate = split[1], Dikaiopraktikos = float.Parse(split[2]), Iperimerias = float.Parse(split[3]) });
                }
                return output;
            }
            else
            {
                Console.WriteLine("File doenst exist");
                return null;
            }

        }
    }
}
