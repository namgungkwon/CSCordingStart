using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;

namespace _142_Tasks
{
    internal class Program
    {
        static void TaskMethod()
        {
            Thread.Sleep(500);
            Console.WriteLine("TaskMethod");
        }

        static int TaskMethodParam(object num)
        {
            Thread.Sleep(200);
            Console.WriteLine("TaskMethod num: " + num);
            return (int)num * 10;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Start");

            Task aa = new Task(TaskMethod);
            aa.Start();

            Task<int> bb = new Task<int>(TaskMethodParam, 10);
            bb.Start();
            bb.Wait();
            Console.WriteLine("Result: " + bb.Result);

            //aa.Wait(); // 대기하지 않으면 비동기 TaskMethod 종료

            Console.WriteLine("Main Thread End");
        }
    }
}
