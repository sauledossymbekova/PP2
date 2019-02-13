using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write text");

            string text = Console.ReadLine();
            File.WriteAllText("path.txt", text);
            string a = File.ReadAllText("path.txt");
            File.WriteAllText("path1.txt", a);
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("tap 1 to continue");
            if (b==1)
            {
                File.Delete("path.txt");
            }
            Console.ReadKey();
        }
    }
}
