﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _067_Check
{
    internal class Program
    {
        static void Start()
        {
            Console.WriteLine("성적 프로그램 - Method");
        }

        static void Input(ref int kor, ref int mat, ref int eng)
        {
            Console.Write("국어 성적 입력(정수)? ");
            kor = int.Parse(Console.ReadLine());

            Console.Write("수학 성적 입력(정수)? ");
            eng = int.Parse(Console.ReadLine());

            Console.Write("영어 성적 입력(정수)? ");
            mat = int.Parse(Console.ReadLine());
        }

        static int TotalSum(int kor, int mat, int eng)
        {
            return kor + mat + eng;
        }

        static void Average(int total, out float average)
        {
            average = (float)total / 3;
        }
        static void Main(string[] args)
        {
            int kor = 0;
            int eng = 0;
            int mat = 0;
            int total;
            float average;

            Start();
            Input(ref kor, ref mat, ref eng);
            total = TotalSum(kor, mat, eng);
            Average(total, out average);

            Console.WriteLine("Total: {0}  Average {1}", total, average);
        }
    }
}
