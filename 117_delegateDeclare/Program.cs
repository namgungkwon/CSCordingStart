﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _117_delegateDeclare
{

    delegate void DelegateTest(int a, int b);
    internal class Program
    {
        static void Sum(int a, int b)
        {
            Console.WriteLine("a + b = " + (a + b));
        }
        static void Main(string[] args)
        {
            //1: 기본선언
            DelegateTest dt = new DelegateTest(Sum);

            //2: 간략한 선언
            DelegateTest dt2 = Sum;

            //3: 익명 함수 선언
            DelegateTest dt3 = delegate (int a, int b)
            {
                Console.WriteLine("a + b = " + (a + b));
            };

            //4. 람다식 선언
            DelegateTest dt4 = (a, b) =>
            {
                Console.WriteLine("a + b = " + (a + b));
            };

            dt(1, 1);
            dt2(2, 2);
            dt3(3, 3);
            dt4(4, 4);
        }
    }
}
