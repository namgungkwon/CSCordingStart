using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _135_File_BinaryFormatter
{
    [Serializable]

    struct Player
    {
        public string _Name;
        public int _Level;
        public double _Exp;
    }

    internal class Program
    {
        const string fileName = "list.dat";
        static void Main(string[] args)
        {
            List<Player> listPlayers = new List<Player>();

            for (int i = 0; i < 10; i++)
            {
                Player player = new Player();
                player._Name = i.ToString();
                player._Level = i;
                player._Exp = i * 10;

                listPlayers.Add(player);
            }

            // 쓰기
            FileStream fsW = new FileStream(fileName, FileMode.Create);

            BinaryFormatter bfW = new BinaryFormatter();
            bfW.Serialize(fsW, listPlayers);

            fsW.Close();


            // 읽기
            FileStream fsR = new FileStream(fileName, FileMode.Open);

            BinaryFormatter bf2 = new BinaryFormatter();
            List<Player> readPlayers = (List<Player>)bf2.Deserialize(fsR);


            foreach(var data in readPlayers)
            {
                Console.WriteLine("Name: {0}, Level: {1}, EXP: {2}", data._Name, data._Level, data._Exp);
            }

            fsR.Close();
        }
    }
}
