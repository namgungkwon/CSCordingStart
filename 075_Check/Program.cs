using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _075_Check
{

   
    internal class Program
    {
        static void InputID(int[] ID, int index)
        {
            Console.Write("학생 ID를 입력하세요?  ");
            ID[index] = int.Parse(Console.ReadLine());
        }

        static void InputKor(int[] kor, int index)
        {
            Console.Write("국어 점수를 입력하세요?  ");
            kor[index] = int.Parse(Console.ReadLine());
        }
        static void InputMath(int[] math, int index)
        {
            Console.Write("수학 점수를 입력하세요?  ");
            math[index] = int.Parse(Console.ReadLine());
        }
        static void InputEng(int[] eng, int index)
        {
            Console.Write("영어 점수를 입력하세요?  ");
            eng[index] = int.Parse(Console.ReadLine());
        }
        static void PrintID(int max, int[] ID)
        {
            for(int i = 0; i < max; i++)
            {
            Console.WriteLine("학생 ID :  {0}", ID[i]);
            }
        }
        static int CheckID(int id, int max, int[] ID)
        {
            
            for(int i = 0;  i < max; i++)
            {
                if (ID[i] == id)
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int MAX = 3;

            int[] ID = new int[MAX];
            int[] kor = new int[MAX];
            int[] math = new int[MAX];
            int[] eng = new int[MAX];

            for(int i = 0; i < MAX; i++)
            {
                InputID(ID, i);
                InputKor(kor, i);
                InputMath(math, i);
                InputEng(eng, i);
            }

            Console.Clear();

            while (true)
            {
                PrintID(MAX, ID);

                Console.WriteLine("학생 아이디를 입력하세요? (0)나가기  ");
                int ans = int.Parse(Console.ReadLine());
                if (ans == 0) break;

                int IDIndex = CheckID(ans, MAX, ID);
                if (IDIndex >= 0)
                {
                    int total = kor[IDIndex] + math[IDIndex] + eng[IDIndex];
                    float average = (float)total / 3f;

                    Console.WriteLine("국어 점수:  {0}", kor[IDIndex]);
                    Console.WriteLine("수학 점수:  {0}", math[IDIndex]);
                    Console.WriteLine("영어 점수:  {0}", eng[IDIndex]);
                    Console.WriteLine("총점:  {0}", total);
                    Console.WriteLine("평균:  {0}", average);
                    Console.WriteLine();
                }
                else Console.WriteLine("학생 아이디가 없어요. 다시 입력하세요.");
            }
        }
    }
}
