using System;
using System.Collections;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _101_Check
{
    class CStudent
    {
        protected int id;
        protected int kor;
        protected int math;
        protected int eng;

        public int ID { get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }

        public CStudent()
        {
            this.id = 0;
            this.kor = 0;
            this.math = 0;
            this.eng = 0;
        }

        public void InputID()
        {
            Console.Write("학생 ID를 입력하세요?  ");
            this.id = int.Parse(Console.ReadLine());
        }
        public void InputKor()
        {
            Console.Write("국어 점수를 입력하세요?  ");
            this.kor = int.Parse(Console.ReadLine());
        }
        public void InputMath()
        {
            Console.Write("수학 점수를 입력하세요?  ");
            this.math = int.Parse(Console.ReadLine());
        }
        public void InputEng()
        {
            Console.Write("영어 점수를 입력하세요?  ");
            this.eng = int.Parse(Console.ReadLine());
        }

        public void PrintID()
        {
            Console.WriteLine("학생 ID :  {0}", this.ID);
        }

        public int GetTotal()
        {
            return kor + eng + math;
        }
    }
    internal class Program
    {
        static void PrintID(Hashtable hashStudents)
        {
            foreach (int key in hashStudents.Keys)
            {
                CStudent castData = (CStudent)hashStudents[key];
                castData.PrintID();
            }
        }
        static int CheckID(int id, Hashtable hashtable)
        {
            if (hashtable.ContainsKey(id))
                return id;
            return -1;
        }
        static void Main(string[] args)
        {
            int inputSel = 0;

            Hashtable hashStudents = new Hashtable();


            

            while(true)
            {
                Console.WriteLine("== 성적 입력중 == (0)나가기  ");
                inputSel = int.Parse(Console.ReadLine());
                if (inputSel == 0) break;

                CStudent temp = new CStudent();
                temp.InputID();
                temp.InputKor();
                temp.InputMath();
                temp.InputEng();

                hashStudents.Add(temp.ID, temp);
                Console.WriteLine();

            }

            Console.Clear();

            while (true)
            {

                PrintID(hashStudents);

                Console.WriteLine("학생 아이디를 입력하세요? (0)나가기  ");
                inputSel = int.Parse(Console.ReadLine());
                if (inputSel == 0) break;
                int selID = CheckID(inputSel, hashStudents);

                if (selID >= 0)
                {
                    CStudent selCStudent = (CStudent)hashStudents[selID];
                    Console.WriteLine("국어 점수:  {0}", selCStudent.KOR);
                    Console.WriteLine("수학 점수:  {0}", selCStudent.MATH);
                    Console.WriteLine("영어 점수:  {0}", selCStudent.ENG);
                    Console.WriteLine("총점:  {0}", selCStudent.GetTotal());
                    Console.WriteLine("평균:  {0}", selCStudent.GetTotal() / 3f);
                    Console.WriteLine();
                }
                else Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요.");
            }
        }
    }
}
