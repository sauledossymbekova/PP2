using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            int n = int.Parse(n1);
            string a = "[*]";
            for (int i=0; i<n; i++)
            {
                Console.WriteLine(a+" ");
                
                Console.WriteLine("");
                
            }
            Console.ReadKey();
        }
        
    }
}
