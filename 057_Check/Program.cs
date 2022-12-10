using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _057_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int Max = 0;
            int Min = 0;
            int ans;


            for(int i = 0; i < 5; i++)
            {
                Console.Write("학생의 성적을 입력하세요: ");
                ans = int.Parse(Console.ReadLine());

                if(ans >= Max) Max = ans;
                if(ans <= Min) Min = ans;
            }
            Console.WriteLine("최대값: {0}  최소값: {1}", Max, Min);
        }
    }
}
