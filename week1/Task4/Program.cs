using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args) //2d array
        {
            int n = int.Parse(Console.ReadLine()); // converting firs line as number
            string[,] arr = new string[n,n]; // new 2d string array nxn
            for(int i = 0; i < n; i++) // i строки j столбцы // i from 0 to n
            {
                for(int j=0; j<=i;j++)
                    arr[i, j] = "[*]"; //while j from 0 till less than i element is equal to the symbol
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++) //double loop
                
                    Console.Write(arr[i,j]); // print elements
                    Console.WriteLine();
            }
            //for (int i=0; i<=n; i++)
            //{
            //    for (int j = 0; j <= i - 1; j++)
            //    {
            //        Console.Write("[*]");
            //    }
            //        Console.WriteLine();
            //}
            Console.ReadKey();
        }
    }
}
