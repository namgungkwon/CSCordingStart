using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _082_as
{

    class Base
    {
        int num;  // protect 속성이 아니니까 자식클래스에서 받아 쓸 수 없음

        public void Print()
        {
            Console.WriteLine("num: {0}", num);
        }
    }

    class AA : Base
    {
        int a;

        public void PrintA()
        {
            Console.WriteLine("a: {0}", a);
        }

    }

    class BB : Base
    {
        int b;

        public void PrintB()
        {
            Console.WriteLine("b: {0}", b);
        }
    }

        internal class Program
    {
        static void Main(string[] args)
        {
            Base _base = new Base();
            _base.Print();

            Base aa = new AA();
            aa.Print();

            if(aa is BB)
            {
                Console.WriteLine("aa는 BB의 객체 입니다.");
            }
            else if(aa is AA)
            {
                Console.WriteLine("aa는 AA의 객체 입니다.");
            }

            Base bb = new BB();

            //BB copyBB = (BB)bb;    캐스팅 해도 잘 돌아감
            BB copyBB = bb as BB;
            if(null != copyBB)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("copyBB는 BB객체를 형식 변환!!");
                copyBB.PrintB();
            }

            //AA copyAA = (AA)bb;   // 예외 발생
            AA copyAA = bb as AA;
            if(null == copyAA)
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("copyAA는 AA객체가 아니므로 null!!");

                copyAA = new AA();
                copyAA.Print();
                copyAA.PrintA();

                AA asAA = copyAA as AA;
                asAA.PrintA();
            }
        }
    }
}
