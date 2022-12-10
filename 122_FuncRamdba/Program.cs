using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_FuncRamdba
{
    delegate void dPrint(string str);
    delegate void dFunc();
    internal class Program
    {
        static public void CallPrint(string str)
        {
            Console.WriteLine(str);
        }
        static public void CallBackFunc(dPrint dp, string msg)
        {
            if (null != dp)
            {
                dp("CallBackFunc: " + msg);
            }
        }
        static void Main(string[] args)
        {
            CallBackFunc(CallPrint, "Hello");
            CallBackFunc(delegate (string str) { Console.WriteLine(str); }, "Hello");
            CallBackFunc((string str) => { Console.WriteLine(str); }, "Hello");
            CallBackFunc((str) => Console.WriteLine(str), "Hello");
            CallBackFunc(str => Console.WriteLine(str), "Hello");

            dFunc dfunc = () => Console.WriteLine("No Params"); // 파라미터가 없는 경우에도 ()를 반드시 표시
        }
    }
}
