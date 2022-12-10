using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Data3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte sbyteData = 255;
            sbyte sbyteData2 = (sbyte)sbyteData;
            int num = (int)sbyteData;

            Console.WriteLine("sbyteData: " + sbyteData);
            Console.WriteLine("sbytaData2: " + sbyteData2);
            Console.WriteLine("num: " + num);
        }
    }
}
