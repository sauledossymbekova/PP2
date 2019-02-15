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
            string name = "text.txt";                           //name of file
            string where1 = @"C:\Users\Saule\Desktop\test";      //first path of created file
            string where2 = @"C:\Users\Saule\Desktop\pp2\test2"; //second path where will be copied

            string file1 = Path.Combine(where1, name); // final first source
            string file2 = Path.Combine(where2, name); //final second source

            FileStream fs = File.Create(file1); //create first file
            fs.Close();
            File.Copy(file1, file2, true); //copy file1 to file2
            File.Delete(file1); //delete first file
            Console.ReadKey();
        }
    }
}
