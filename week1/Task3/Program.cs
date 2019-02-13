using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());     // reading 1st line as number "n"
            string line = Console.ReadLine();         // reading 2nd line and assign as string "s"
            string[] str = new string[n];                  // creating new string ARRAY "str", which will have n elements
                str= line.Split();          // entering elements into string ARRAY "str" from string "line"; each element is divided by " "
            int[] int1 = new int[n];                       // creating new int array  "int1", which will have n elements

            for (int i=0; i < n; i++) //
            {
                int1[i] = int.Parse(str[i]);// convert elements from string array "str" into INTEGERS and then, entering elements in int array "int1"  
            }


            int[] int2 = new int [n*2];                    // creating new int array"int2", which will have n*2 integers
            for (int i = 0; i < n; i++)            // counter till the n; 0,1,2; 
            {
                int2[i*2] = int1[i] ;        // (i*2)th element of int2 equals to i'th element of int1 array
                int2[(i*2)+1] = int1[i];     // (i*2+1)th element of int2 equals to i'th element of int1 array
            }
            for (int i = 0; i < int2.Length; i++)  // till the end of the second array
            {
                Console.Write(int2[i] + " "); //print out all elements of int2 array through " "
            }
            Console.ReadKey();



            //string n = Console.ReadLine();
            //string line = Console.ReadLine();
            //string[] arr = line.Split();
            //string res = "";
            //foreach (var x in arr)
            //{
            //    int y = int.Parse(x);
            //    res = res + " " + x + " " + x;

            //}
            //Console.WriteLine(res);
            
        }
    }
}
