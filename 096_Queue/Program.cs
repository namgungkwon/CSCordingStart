using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _096_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("a");
            queue.Enqueue("b");
            queue.Enqueue("c");

            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("queue data: {0}", queue.Peek());  //Peek 꺼내쓰기위해 가장 먼저 나오는  queue 출력

            while(queue.Count > 0)
            {
                Console.WriteLine("queue data: {0}, count: {1}", queue.Dequeue(), queue.Count);
            }

            Console.WriteLine("배열데이터로 초기화");
            int[] arrData = { 100, 200, 300 };
            Queue queueCopy = new Queue(arrData);

            foreach(int data in queueCopy)
            {
                Console.WriteLine("queueCopy Data: " + data);
            }
        }
    }
}
