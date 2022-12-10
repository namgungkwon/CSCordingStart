using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _097_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");

            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Console.WriteLine("stack data: {0}", stack.Peek());

            while(stack.Count > 0)
            {
                Console.WriteLine("stack data: {0}, count: {1} {2}", stack.Pop(), stack.Count);
            }

            Console.WriteLine("배열데이터 초기화");
            int[] arrData = { 100, 200, 300 };
            Stack stackCopy = new Stack(arrData);

            foreach(int data in stackCopy)
            {
                Console.WriteLine("stackCopy data:" + data);
            }
        }
    }
}
