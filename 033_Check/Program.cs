using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _033_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("국어 점수 입력하세요: ");
            int score1 = int.Parse(Console.ReadLine()); 
            Console.Write("영어 점수 입력하세요: ");
            int score2 = int.Parse(Console.ReadLine());
            Console.Write("수학 점수 입력하세요: ");
            int score3 = int.Parse(Console.ReadLine());
            Console.Write("과학 점수 입력하세요: ");
            int score4 = int.Parse(Console.ReadLine());

            int sum = score1 + score2 + score3 + score4;
            float average = (float)sum / 4f; 

            Console.WriteLine($"국어: {score1}, 영어: {score2}, 수학: {score3}, 과학: {score4}");
            Console.WriteLine("총점: {0},    평균: {1}", sum, average);
        }
    }
}
