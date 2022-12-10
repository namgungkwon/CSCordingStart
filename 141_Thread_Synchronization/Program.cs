using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _141_Thread_Synchronization
{
    internal class Program
    {
        static readonly object thisLock = new object();

        static int _index = 0;

        static void RunThread()
        {
            DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();

            // 크리티컬 섹션
            // lock 블록이 끝나기 전까지 다른 쓰레드는 이 코드를 실행 X

            lock (thisLock)
            {
                _index++;

                Console.WriteLine(String.Format("RunThread Start"));

                Console.WriteLine("RunThread dex: {0:N2}", sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);

                Console.WriteLine(String.Format("RunThreadEnd"));
                Console.WriteLine("_index: " + _index);
            }
        }

        //_index의 값을 순차적으로 증가
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread aa = new Thread(new ThreadStart(RunThread));
                aa.Start();
            }
        }
    }
}
