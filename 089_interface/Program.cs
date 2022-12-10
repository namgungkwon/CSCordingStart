using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _089_interface
{
    interface IAA
    {
        //public int a; //에러(필드불가)
        //private void IPrint(){} //에러(private)
        //public void IPrint(); //에러(public)
        int A { get; set; }
        void IAAPrint();
    }

    interface IBB
    {
        void IBBPrint();
    }

    class Super
    {
        protected int num;

        public virtual void Print()
        {
            Console.WriteLine("=========================================");
        }
    }

    class AA : IAA
    {
        public int A { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IAAPrint()
        {
            Console.WriteLine("class AA interface IAA에 IAAPrint() 재정의"); // 무조건 재정의 해주어야함
        }
    }

    class BB : IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }

        public void IAAPrint()
        {
            Console.WriteLine("class BB interface IAA에 IAAPrint() 재정의");
        }
        public void IBBPrint()
        {
            Console.WriteLine("class BB interface IBB에 IBBPrint() 재정의");
        }
    }

    class CC : Super, IAA, IBB
    {
        public int A
        {
            get { return A; }
            set { A = value; }
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("class Super => Print() 재정의");
        }

        public void IAAPrint()
        {
            Console.WriteLine("class CC interface IAA에 IAAPrint() 재정의");
        }

        public void IBBPrint()
        {
            Console.WriteLine("class CC interface IBB에 IBBPrint() 재정의");
        }
    }

    class Program
    {
        static void Main()
        {
            AA aa = new AA();
            aa.IAAPrint();

            BB bb = new BB();
            bb.IAAPrint();
            bb.IBBPrint();

            //IAA Iaaa = new IAA(); // 인스턴스를 생성할 수 없다.
            IAA Iaa = new AA();     // 참조는 가능
            Iaa.IAAPrint();

            IBB Ibb = bb as IBB;
            Ibb.IBBPrint();

            CC cc = new CC();
            cc.Print();
            cc.IAAPrint();
            cc.IBBPrint();

            Super sCC = cc as Super;
            sCC.Print();

            IAA IAAcc = cc as IAA;
            IAAcc.IAAPrint();

            IBB IBBcc = cc as IBB;
            IBBcc.IBBPrint();
        }
    }
}

