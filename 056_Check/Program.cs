using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _056_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int rndNum = rnd.Next(1, 100);
            int i;
            int ans = 0;

            for(i = 0; !(ans == rndNum); i++)
            {
                Console.Write("1~99사이 어떤 숫자일까요(단, 0은 나가기)");
                ans = int.Parse(Console.ReadLine());

                if(ans == 0)
                {
                    Console.WriteLine("종료합니다.");
                    break;
                }

                if (ans > rndNum) Console.WriteLine("입력한 수는 커요");
                else if (ans < rndNum) Console.WriteLine("입력한 수는 작아요");
                else Console.WriteLine("==정답입니다.==");
            }
            Console.WriteLine("총 {0}번 시도", i);
        }
    }
}
