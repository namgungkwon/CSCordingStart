using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _132_File01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path;

            if (args.Length <= 0)
            {
                path = Directory.GetCurrentDirectory();
                path += "\\a.txt";

                Console.WriteLine("path: "+ path);
            }
            else
            {
                path = args[0];
            }

            if (File.Exists(path))  // using System.IO;
            {
                Console.WriteLine("\nGetCreationTime: " + File.GetCreationTime(path));
            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }

            FileInfo fileInfo = new FileInfo("b.txt");
            FileStream ff = fileInfo.Create();

            ff.Close();
        }
    }
}
