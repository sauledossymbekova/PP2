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
            FileStream fs = new FileStream("file.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadLine();
            //string[] arr = line.Split();
            bool b;
            b = true;
            for (int i = 0; i < line.Length / 2; i++)
            {

                if (line[i] != line[line.Length - i - 1])
                {

                    b = false;
                }

            }
            if (b)
                Console.WriteLine("Yes");

            if (b == false)
            {
                Console.WriteLine("No");

            }
            sr.Close();
            fs.Close();
            Console.ReadKey();
        }
        
        }
    }


