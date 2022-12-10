using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _040_Operator_bit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 15;        //  1111
            int b = 22;        //1 0110 
            int c = a & b;     //0 0110
            Console.WriteLine("a & b: " + c);

            int d = a | b;     //1 1111
            Console.WriteLine("a | b: " + d);

            int e = a ^ b;     //1 1001
            Console.WriteLine("a ^ b: " + e);

            int f = a << 2;    //11 1100
            Console.WriteLine("a << 2: " + f);
            Console.WriteLine("a << 1: " + (a << 1));

            int g = 20 >> 2;
            Console.WriteLine("20 >> 2: " + g);
            Console.WriteLine("(20 >> 1): " + (20 >> 1));

            int h = ~b;
            Console.WriteLine("h = ~b: " + h);

            int i = (~b) >> 2;
            Console.WriteLine("i = (~b) >> 2: " + i);

            string s = Convert.ToString(a, 2).PadLeft(32, '0');
            Console.WriteLine("s: " + s);
            s = Convert.ToString(b, 2).PadLeft(32, '0');
            Console.WriteLine("s: " + s);


        }
    }
}
