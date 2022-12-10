using System;
using System.Collections;
using System.Net;

namespace _102_Check
{
    class CPlus
    {
        protected int a;
        protected int b;
        protected int result;

        public int A { get { return a; } }
        public int B { get { return b; } }
        public int RESULT { get { return result; } }
        public CPlus()
        {
            a = 0;
            b = 0;
        }

        public void num1()
        {
            Console.WriteLine("첫번째 수를 입력 해 주세요?");
            this.a = int.Parse(Console.ReadLine());
        }

        public void num2()
        {
            Console.WriteLine("두번째 수를 입력 해 주세요?");
            this.b = int.Parse(Console.ReadLine());
        }

        public void Plus()
        {
            this.result = a + b;
        }



        public void PrintResult()
        {
            Console.WriteLine("{0} + {1} = {2}", this.a, this.b, result);
        }
    }

    internal class Program
    {
        static bool CheckEnd()
        {
            Console.WriteLine("추가로 계산할까요(1: OK, 0: NO)");
            return (int.Parse(Console.ReadLine()) == 0);
        }
        static void Main(string[] args)
        {

            Queue queueplus = new Queue();

            while (true)
            {
                if (CheckEnd()) break;

                CPlus cplus = new CPlus();
                cplus.num1();
                cplus.num2();
                cplus.Plus();
                cplus.PrintResult();

                queueplus.Enqueue(cplus);
            }

            foreach(CPlus data in queueplus)
            {
                data.PrintResult();
            }
        }
    }
}
