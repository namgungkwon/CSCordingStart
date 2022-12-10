using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _092_Property
{
    class AA
    {
        private int num;
        private string name;

        public int NUM { get; set; }
        public string NAME { get; set; } = "NoName";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            Console.WriteLine("aa.num: {0}", aa.NUM);
            Console.WriteLine("aa.NAME: {0}", aa.NAME);

            aa.NUM = 100;
            Console.WriteLine("aa.num: {0}", aa.NUM);

            aa.NAME = "JACK";
            Console.WriteLine("aa.NAME: {0}", aa.NAME);
        }
    }
}
