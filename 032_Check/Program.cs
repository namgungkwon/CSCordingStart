using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _032_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            string b = "AAA";
            float c = 0.123f;
            char d = 'A';

            Console.WriteLine("a: {0}, a.Gettype(): {1}", a, a.GetType());
            Console.WriteLine("b: {0}, b.Gettype(): {1}", b, b.GetType());
            Console.WriteLine("c: {0}, c.Gettype(): {1}", c, c.GetType());
            Console.WriteLine("d: {0}, d.Gettype(): {1}", d, d.GetType());
        }
    }
}
