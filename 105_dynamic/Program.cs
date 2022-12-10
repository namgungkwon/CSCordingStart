using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _105_dynamic
{
    internal class Program
    {
        static T AddArray<T>(T[] arrDatas)
        {
            // object temp = 0; // 박싱, 언박싱 발생
            dynamic temp = default(T);
            for (int i = 0; i < arrDatas.Length; i++)
            {
                temp += arrDatas[i];
            }
            return temp;
        }

        static T SumArray<T>(T[] arrDatas)
        {
            T temp = default(T);
            for (int i = 0; i < arrDatas.Length; i++)
            {
                temp += (dynamic)arrDatas[i];
            }
            return temp;
        }

        static void PrintArray<T>(T[] arrdatas)
        {
            foreach (var data in arrdatas)
            {
                Console.WriteLine("data: {0}", data);
            }
        }
        static void Main(string[] args)
        {
            int[] arrNums = { 1, 2, 3, 4, 5 };

            Console.WriteLine("AddArray: {0}", SumArray(arrNums));
            PrintArray(arrNums);
        }
    }
}
