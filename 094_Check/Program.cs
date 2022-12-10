using System;

namespace _076_Check
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
            Console.WriteLine("추가로 계산할까요(1: OK, 0: NO, 단 총 10번까지 가능)");
            return (int.Parse(Console.ReadLine()) == 1);
        }
        static void Main(string[] args)
        {
            const int MAX = 10;
            int count = 0;

            CPlus[] cplus = new CPlus[MAX];

            for (int i = 0; i < cplus.Length; i++)
            {
                cplus[i] = new CPlus();
                cplus[i].num1();
                cplus[i].num2();
                cplus[i].Plus();
                cplus[i].PrintResult();
                count++;
                if (!CheckEnd()) break;
            }

            for (int j = 0; j < count; j++)
            {
                cplus[j].PrintResult();
            }

        }
    }
}
