using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;


namespace Checkpoint01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            const string LINE = "------------------------------------------";
            const int END_LINE = 40;
            const int DELAY_TIME = 50;

            int runA = 0;
            int runB = 0;
            int runC = 0;
            int runD = 0;
            const int clear = 0;


            while (true)
            {

                Thread.Sleep(DELAY_TIME);
                Console.Clear();

                ++runA;
                ++runB;
                ++runC;
                ++runD;

                switch (rnd.Next(1, 5))
                {
                    case 1:
                        ++runA;
                        break;
                    case 2:
                        ++runB;
                        break;
                    case 3:
                        ++runC;
                        break;
                    case 4:
                        ++runD;
                        break;
                }


                Console.WriteLine(LINE);

                for (int i = 0; i < runA; i++)
                    Console.Write(" ");
                Console.Write("1");
                for (int i = 0; i < (END_LINE - runA); i++)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runB; i++)
                    Console.Write(" ");
                Console.Write("2");
                for (int i = 0; i < (END_LINE - runB); i++)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runC; i++)
                    Console.Write(" ");
                Console.Write("3");
                for (int i = 0; i < (END_LINE - runC); i++)
                    Console.Write(" ");
                Console.WriteLine("|");

                for (int i = 0; i < runD; i++)
                    Console.Write(" ");
                Console.Write("4");
                for (int i = 0; i < (END_LINE - runD); i++)
                    Console.Write(" ");
                Console.WriteLine("|");

                Console.WriteLine(LINE);

                if (runA >= END_LINE || runB >= END_LINE || runC >= END_LINE || runD >= END_LINE)
                {
                    int win;

                    if (runA >= END_LINE) win = 1;
                    else if (runB >= END_LINE) win = 2;
                    else if (runC >= END_LINE) win = 3;
                    else win = 4;

                    Console.WriteLine("결과: !!{0}번 선수 우승!!", win);
                    Console.WriteLine("다시 하시려면 0번을 누르세요~~");

                    if (Console.ReadLine() == "0")
                    {
                        runA = clear;
                        runB = clear;
                        runC = clear;
                        runD = clear;
                    }
                    else break;
                }
            }
        }
    }
}
