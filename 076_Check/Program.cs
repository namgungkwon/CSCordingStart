using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _076_Check
{
    internal class Program
    {  
        static int InputNumber(int temp)
        {
            int ans;
            if (temp == 0)
            {
                Console.WriteLine("첫번째 수를 입력 해 주세요?");
                ans = int.Parse(Console.ReadLine());
            }
            else 
            {
                Console.WriteLine("두번째 수를 입력 해 주세요?");
                ans = int.Parse(Console.ReadLine());
            }

            return ans;
        }
        static void PrintResult(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, sum);
        }
        static bool CheckEnd()
        {
            Console.WriteLine("추가로 계산할까요(1: OK, 0: NO, 단 총 10번까지 가능)");
            return (int.Parse(Console.ReadLine()) == 1);
        }
        static void Main(string[] args)
        {
            int[,] Num = new int[10, 10];
            bool Check = true;
            int count = 0;

            while (Check)
            {
                int temp = 0;

                Num[count, temp] = InputNumber(temp++);
                Num[count, temp] = InputNumber(temp--);
                PrintResult(Num[count, 0], Num[count++, 1]);
                Check = CheckEnd();
                if(count >= 10) break;
            }

            for(int i = 0; i < count; i++)
                PrintResult(Num[i, 0], Num[i, 1]);
        }
    }
}
