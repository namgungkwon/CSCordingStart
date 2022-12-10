using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _091_Property01
{
    class AA
    {
        private int num;

        public int NUM
        {
            get { return num; }
            set { num = value; }  // set을 구현하지 않으면 readonly 와 같은 읽기 전용
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            AA aa = new AA();
            //aa.num = 100;  //정보은닉이 되어있다
            aa.NUM = 100;

            Console.WriteLine("aa.NUM: {0}", aa.NUM);
        }
    }
}
