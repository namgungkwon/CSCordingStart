using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;

namespace _139_Thread01
{
    internal class Program
    {

        static void RunThread(int index)
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index: {0} Start", index));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThread index: {0} sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThread index: {0} End", index));
            Console.WriteLine();
        }

        static void RunThread()
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThread index: 0 Start"));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThread index: {0} sec: {1:N2}", "0", sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine("RunThread index: 0 End");
            Console.WriteLine();
        }

        static void RunThreadObject(object index)
        {
            var sw = Stopwatch.StartNew();

            Console.WriteLine(string.Format("RunThreadobject index: {0} Start", index));

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("RunThreadobject index: {0} sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                Thread.Sleep(100);
            }

            Console.WriteLine(string.Format("RunThreadobject index: {0} End", index));
            Console.WriteLine();
        }

        static void RunExeption(int index)
        {
            DateTime start = DateTime.Now;
            var sw = Stopwatch.StartNew();

            Console.WriteLine(String.Format("RunThread index: {0} Start", index));

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("RunThread index: {0} sec: {1:N2}", index, sw.ElapsedMilliseconds / 1000.0f);
                    Thread.Sleep(100);
                }
                Console.WriteLine("RunThread index: {0} End", index);
                Console.WriteLine();
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("===== finally =====");
            }
        }
        static void Main(string[] args)
        {
            Thread aa = new Thread(() => RunExeption(0));
            aa.Start();
            Thread.Sleep(300);
            aa.Abort();
            Console.WriteLine(String.Format("Abort"));
            Console.WriteLine();

            Thread bb = new Thread(() => RunExeption(1));
            bb.Start();
            Thread.Sleep(300);
            bb.Join();
            Console.WriteLine(String.Format("Join"));
            Console.WriteLine();

            Thread cc = new Thread(() => RunExeption(1));
            cc.Start();
            Thread.Sleep(300);
            cc.Interrupt();
            Console.WriteLine(String.Format("Interrupt"));
            Console.WriteLine();
        }
    }
}
