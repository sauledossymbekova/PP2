using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = File.ReadAllLines("file.txt"); //приравниваем строковой массив"texts" на то что внутри файла
            foreach (string text in texts) //для каждой строки названной "text" в массиве "texts"
            {
                string[] arr = text.Split(); // строку "text" приравниваем на массив и отделяем каждый элемент
                for (int i = 0; i < arr.Length / 2; i++) // пробегаемся по форику до элемента ровно по середине 
                {
                    if (arr[i] != arr[arr.Length - i - 1]) // если зеркальные элементы не ровны
                    {
                        Console.WriteLine("No"); // то, выводим "No"
                        break;
                    }
                }
                Console.WriteLine("Yes"); //если все элементы обходят услофия то это палиндром

            }
            Console.ReadKey();
        }
    }
}
