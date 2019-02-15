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
            using (FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Read)) { // opening read file.txt, making equal to variable fs
                StreamReader sr = new StreamReader(fs); // all from fs give to the sr потоково
                string line = sr.ReadLine(); // new variable is equal to the line-reading sr variable
                bool b;
                b = true;
                for (int i = 0; i < line.Length / 2; i++) //till the center of string
                {
                    if (line[i] != line[line.Length - i - 1]) // if the mirror-numbers are not equal so it is false
                    {

                        b = false;
                    }

                }
                if (b)
                    Console.WriteLine("Yes"); //if it is  true, print out Yes

                if (b == false)
                {
                    Console.WriteLine("No"); //if false print No

                }
            }
            
            Console.ReadKey();
        }
        
        }
    }


