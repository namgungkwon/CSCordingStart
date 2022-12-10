using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _080_static
{
    class AA
    {
        public static int a;
        public static int b;
        public static readonly int c = 200; // 상수화 된다.

        public static void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }
    }

    class BB
    {
        public int a;
        public int b;
        public void Print()
        {
            Console.WriteLine("a: {0}", a);
            Console.WriteLine("b: {0}", b);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AA.a = 10; //객체 생성없이 바로 접근
            AA.b = 100;
            //AA.c = 200; //오류 : readonly 이므로 변경 불가

            AA.Print();

            //BB.a            //오류
            //BB.b
            //BB.Print();

            BB bb = new BB();

            bb.a = 100;
            bb.b = 200;

            bb.Print();
        }
    }
}
