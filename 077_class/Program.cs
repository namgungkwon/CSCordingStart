﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _077_class
{
    class AA
    {
        int num1; // 기본적으로 private 속성
        public int num2, num3;

        public void Print()
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }

        private void PrintPrivate() // 외부 접근 불가
        {
            Console.WriteLine("aa: {0}, bb: {1}, cc: {2}", num1, num2, num3);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            //aa.num1 = 10; // 오류
            aa.num2 = 100;
            aa.num3 = 1000;

            aa.Print();

            // aa.PrintPrivate(); // 외부 접근 불가
        }
    }
}
