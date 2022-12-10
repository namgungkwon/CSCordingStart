﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _106_where
{
    class REF
    {
    }

    class AA<T> where T : struct
    {
        private T sData;

        public AA()
        {
            sData = default(T);
        }

        public void Print()
        {
            Console.WriteLine("" + sData);
        }
    }

    class BB<T> where T : class
    {
        private T sRefData;

        public BB()
        {
            sRefData = default(T);
        }

        public void Print()
        {
            if (sRefData == null) Console.WriteLine("Null sRefData");
            else Console.WriteLine("sRefData: " + sRefData);
        }
    }

    interface II
    {
        void IIPrint();
    }

    class CC<T> where T : II // interface로 제한
    {
        public T _interface;
    }

    class DD : II
    {
        public void IIPrint()
        {
            Console.WriteLine("DDbase: ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //AA<REF> aa = new AA<REF>();  //오류 : null이 허용되지 않는 value type
            AA<int> aa = new AA<int>();
            aa.Print();

            //BB<int> bb = new BB<int>();  //오류 : 참조형식이 아님
            BB<REF> bb = new BB<REF>();
            bb.Print();

            CC<II> cc = new CC<II>();
            // cc._interface = new REF();  //오류 : 한정자가 interface
            cc._interface = new DD();
        }
    }
}
