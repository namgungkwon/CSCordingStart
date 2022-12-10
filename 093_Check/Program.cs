﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _093_Check
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
        static void PrintID(CStudent[] arrStudents)
        {
            foreach(CStudent data in arrStudents)
            {
                data.PrintID();
            }
        }
        static int CheckID(int id, CStudent[] arrStudents)
        {

            for (int i = 0; i < arrStudents.Length; i++)
            {
                if (id == arrStudents[i].ID)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {

            const int MAX = 3;
            int inputSel = 0;

            CStudent[] arrStudents = new CStudent[MAX];

            
            
            for (int i = 0; i < MAX; i++)
            {
                arrStudents[i] = new CStudent();
                arrStudents[i].InputID();
                arrStudents[i].InputKor();
                arrStudents[i].InputMath();
                arrStudents[i].InputEng();

                Console.WriteLine();
            }


            Console.Clear();

            


            while (true)
            {
                PrintID(arrStudents);

                Console.WriteLine("학생 아이디를 입력하세요? (0)나가기  ");
                inputSel = int.Parse(Console.ReadLine());
                if (inputSel == 0) break;

                int IDIndex = CheckID(inputSel, arrStudents);

                if (IDIndex >= 0)
                {

                    Console.WriteLine("국어 점수:  {0}", arrStudents[IDIndex].KOR);
                    Console.WriteLine("수학 점수:  {0}", arrStudents[IDIndex].MATH);
                    Console.WriteLine("영어 점수:  {0}", arrStudents[IDIndex].ENG);
                    Console.WriteLine("총점:  {0}", arrStudents[IDIndex].GetTotal());
                    Console.WriteLine("평균:  {0}", arrStudents[IDIndex].GetTotal() / 3f);
                    Console.WriteLine();
                }
                else Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요.");
            }
        }
    }
}
