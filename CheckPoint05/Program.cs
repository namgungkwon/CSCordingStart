using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint05
{
    class CStudent
    {
        private int id;
        private int kor;
        private int math;
        private int eng;
        private int total;


        public int ID { get { return id; } }
        public int KOR { get { return kor; } }
        public int MATH { get { return math; } }
        public int ENG { get { return eng; } }
        public int TOTAL { get { return total; } }

        public CStudent(int id, int kor, int math, int eng)
        {
            this.id = id;
            this.kor = kor;
            this.math = math;
            this.eng = eng;

            this.total = kor + math + eng;
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<CStudent> listData = new List<CStudent>();
            bool IsLoop = true;

            InitData(listData);

            do
            {
                Console.WriteLine("메뉴를 골라주세요");
                Console.Write("(1)id 정렬 (2)성적순 정렬 (3)국어점수 정렬 (4)특정 점수 이상 (5)특정 점수 이하 (0) 나가기");
                string inputNum = Console.ReadLine();

                switch (inputNum)
                {
                    case "0":
                        Console.WriteLine("프로그램 종료");
                        IsLoop = false;
                        break;

                    case "1":
                        SortID(listData);
                        break;

                    case "2":
                        SortTotal(listData);
                        break;

                    case "3":
                        SortKor(listData);
                        break;

                    case "4":
                        FindData(listData,true);
                        break;

                    case "5":
                        FindData(listData, false);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("다시 입력하세요.");
                        break;
                }
            } while (IsLoop);
        }

        // 학생 데이터를 생성
        static void InitData(List<CStudent> _listData)
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                CStudent data = new CStudent(i, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));
                _listData.Add(data);
                /*_listData[i] = new CStudent(i, rnd.Next(0, 100), rnd.Next(0, 100), rnd.Next(0, 100));*/
            }
        }

        static void PrintList(List<CStudent> _listData)
        {
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", "ID", "KOR", "MATH", "ENG", "TOTAL");
            Console.WriteLine("======================================");

            foreach (var item in _listData)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", item.ID, item.KOR, item.MATH, item.ENG, item.TOTAL);
            }
        }

        static void SortID(List<CStudent> _listData)
        {
            _listData.Sort(delegate (CStudent a, CStudent b)
            {
                if (a.ID > b.ID)
                    return 1;
                else if (a.ID < b.ID)
                    return -1;
                else
                    return 0;
            });

            Console.WriteLine("아이디 정렬");
            PrintList(_listData);
        }

        static void SortTotal(List<CStudent> _listData)
        {
            List<CStudent> sortdata =
            (from item in _listData
            orderby item.TOTAL descending
            select item).ToList<CStudent>();

            Console.WriteLine("총점 정렬");
            PrintList(sortdata);
        }

        static void SortKor(List<CStudent> _listData)
        {
            _listData.Sort((CStudent a, CStudent b) => { return b.KOR - a.KOR; });

            PrintList(_listData);
        }

        static void FindData(List<CStudent> _listData, bool isUP)
        {
            Console.WriteLine("기준 점수를 입력하세요?");
            string inputData = Console.ReadLine();
            int num = 0;

            try
            {
                num = int.Parse(inputData);
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("입력값 {0} 잘못된 입력입니다. 숫자만 입력하세요", num);
            }
            finally
            {
                if (num <= 0)
                {
                    Console.WriteLine("입력값 {0} 잘못된 입력입니다. 작은 수 입니다", num);
                }

                if (num > 300)
                {
                    Console.WriteLine("입력값 {0} 잘못된 입력입니다. 큰 수 입니다", num);
                }
            }

            if (num >= 0 && num <= 300)
            {
                List<CStudent> finddata =
                    (from item in _listData
                    where isUP ? (item.TOTAL >= num) : (item.TOTAL <= num)
                    orderby item.ID ascending
                    select item).ToList<CStudent>();

                Console.WriteLine("총점 이상정렬");
                PrintList(finddata);
            }
        }
    }
}
