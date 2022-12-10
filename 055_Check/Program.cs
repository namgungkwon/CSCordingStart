using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _055_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int a, b;
            int ans = 0;

            for (int i = 1; i < 6; i++)
            {
                a = rnd.Next(0, 100);
                b = rnd.Next(0, 100);

                Console.WriteLine("{0}: 다음 두 수의 합은 몇?(총 5문제)", i);
                Console.WriteLine("{0} + {1} = ??", a, b);
                
                if(int.Parse(Console.ReadLine()) == (a + b))
                {
                    Console.WriteLine("== 정답 ==");
                    ans++;
                }
                else
                {
                    Console.WriteLine("오답(정답은: {0})", (a + b));
                }
            }
            Console.WriteLine("맞춘 문제는 {0}문제 ", ans);
        }
    }
}
