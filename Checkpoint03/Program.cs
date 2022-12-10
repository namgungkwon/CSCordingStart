using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.ComponentModel;
using System.Security.AccessControl;

namespace Checkpoint03
{
    internal class Program
    {

        const int MAP_X = 7;
        const int MAP_Y = 22;
        const int DELAY_TIME = 200;
        
        static void UpdateView(char[] tile, int[,] map)
        {
            for (int i = 0; i < MAP_X; i++)
            {
                for (int j = 0; j < MAP_Y; j++)
                {
                    int tileIndex = map[i, j];
                    Console.Write(tile[tileIndex]);
                }
                Console.WriteLine();
            }
        }

        static void ClearView()
        {
            Thread.Sleep(DELAY_TIME);
            Console.Clear();
        }

        static void UpdateGo(int[] arrIndexX, int[,]map)
        {
            for (int i = 0; i < arrIndexX.Length; i++)
            {
                int indexMaxX = i + 1;
                int indexY = arrIndexX[i];

                int temp = map[indexMaxX, indexY];
                map[indexMaxX, indexY + 1] = temp;
                map[indexMaxX, indexY] = 0;

                if (arrIndexX[i] < 20)
                    arrIndexX[i]++;
            }
        }

        static bool UpdataRandomGo(int[] arrIndexX, int[,] map, Random rnd)
        {
            for (int i = 0; i < arrIndexX.Length; i++)
            {
                if (arrIndexX[i] > 19)
                    return true;
            }

            int rndIndex = rnd.Next(0, 5);


            int temp = map[rndIndex + 1, arrIndexX[rndIndex]];
            map[rndIndex + 1, arrIndexX[rndIndex] + 1] = temp;
            map[rndIndex + 1, arrIndexX[rndIndex]] = 0;
            arrIndexX[rndIndex]++;

            return false;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //               0    1    2    3    4    5    6    7      
            char[] tile = { ' ', '-', '|', '1', '2', '3', '4', '5' };

            int[,] map = new int[MAP_X, MAP_Y]
            {
         //  0  1  2  3  4  5  6  7  8  9 10 11 12 13 14 15 16 17 18 19 20 21
            {1, 1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1, 1, 1, 1, 1, 1, 1, 1}, //0
            {3, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0, 0, 0, 0, 0, 0, 0, 2}, //1
            {4, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0, 0, 0, 0, 0, 0, 0, 2}, //2
            {5, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0, 0, 0, 0, 0, 0, 0, 2}, //3
            {6, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0, 0, 0, 0, 0, 0, 0, 2}, //4
            {7, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0, 0, 0, 0, 0, 0, 0, 2}, //5
            {1, 1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1, 1, 1, 1, 1, 1, 1, 1} //6
            };

            int[] arrIndexX = { 0, 0, 0, 0, 0 };
            bool isFinish = false;

            while (!isFinish)
            {
                UpdateGo(arrIndexX, map);
                isFinish = UpdataRandomGo(arrIndexX, map, rnd);
                UpdateView(tile, map);

                if (isFinish)
                {
                    for (int i = 0; i < arrIndexX.Length; i++)
                    {
                        if (arrIndexX[i] > 19)
                        {
                            Console.WriteLine("달리기 결과는 {0} 가 우승!!", i+1);
                            break;
                        }
                    }
                        Console.WriteLine("계속하려면 0 입력");
                    if (int.Parse(Console.ReadLine()) == 0)
                        isFinish = false;
                    else break;
                }

                ClearView();
            }
            

        }


    }
}
