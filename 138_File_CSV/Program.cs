using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _138_File_CSV
{
    using SR = StreamReader;
    class Stage
    {
        public string stage { get; set; }
        public int min { get; set; }
        public int max { get; set; }
        public int finish { get; set; }
        public int gold { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            const string fileName = "test.txt";

            int index = 0;
            List<Stage> liststage = new List<Stage>();

            using (SR sr = new SR(new FileStream(fileName, FileMode.Open)))
            {
                while (false == sr.EndOfStream)
                {
                    string readStr = sr.ReadLine();

                    if (index++ >= 1)
                    {
                        string[] splitData = readStr.Split(',');

                        Stage temp = new Stage();
                        temp.stage = splitData[0];
                        temp.min = Convert.ToInt32(splitData[1]);
                        temp.max = Convert.ToInt32(splitData[2]);
                        temp.finish = Convert.ToInt32(splitData[3]);
                        temp.gold = Convert.ToInt32(splitData[4]);
                        liststage.Add(temp); 
                    }
                }
            }

            foreach (var data in liststage)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", data.stage, data.min, data.max, data.finish, data.gold);
                Console.WriteLine();
            }
        }
    }
}
