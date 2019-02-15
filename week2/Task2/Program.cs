using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = File.ReadAllLines("input.txt");        //приравниваем строковой массив"texts" на то что внутри файла
            foreach (string text in texts)                         //для каждой строки названной "text" в массиве "texts"
            {
                string[] arr = text.Split();                       // строку "text" приравниваем на массив и отделяем каждый элементy
                                          
            string res = "";                                       // empty string for result string
            bool b;
            foreach (var x in arr)                                 // running to each element of array            
            {
                b = true;
                int y = int.Parse(x);                              // t as number of elements in array
                if (y == 1)
                    b = false;
                for (int i = 2; i * i <= y; i++)                   //algorithm for checking elements are prime; 1,4
                {
                    if (y % i == 0)                                // if no remainder it is not prime
                    {
                        b = false;                                 // so false
                    }
                }
                if (b)                                             // if there are numbers well gone through algor. so it is prime 
                {
                    res = res + " " + x;                           // will add prime numbers in empty string

                }
            }
            
                File.Create("output.txt"); //create new file
                File.WriteAllText("output.txt", res); // save string into file
                Console.WriteLine("DONE"); // prosto

            }
            Console.ReadKey();
        }
    }
}
