using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _098_Hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashTable = new Hashtable();
            hashTable.Add("pos", 10);
            hashTable.Add("name", "Jack");
            hashTable["weight"] = 10.8f;

            foreach(object key in hashTable.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashTable[key]);
            }

            Console.WriteLine("");

            Hashtable hashTableCopy = new Hashtable()
            {
                ["pos"] = 10,
                ["name"] = "Jack",
                ["weight"] = 10.8f,
            };

            foreach(object key in hashTable.Keys)
            {
                Console.WriteLine("key: {0}, data: {1}", key, hashTable[key]);
            }
        }
    }
}
