using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string line = Console.ReadLine();
            string[] arr = line.Split();
            string res = "";
            foreach (var x in arr)
            {
                int y = int.Parse(x);
                res = res  + " "+x+  " " +x;

            }
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
