using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // reading first line as number and make equal to new int variable n
            string line = Console.ReadLine();      //reading second line and make equal to new string variable line
            string[] str = new string[n];               //creating new string array str and give the value n as number of elements in this array
            int[] int1 = new int[n];                    //creating new int array int1 and give the value n as number of elements in this array
            str = line.Split();                               //making equal string array str to string line, in array elements are divided by " "
            for (int i = 0; i < n; i++)
            {
                int1[i] = int.Parse(str[i]); // converting elements as numbers from array str, and making equal to the int array "int1"
            }
            bool b;    //creating new boolean variable
            int count = 0; // creating new epmty variable
            string res = ""; // empty string for result string

            foreach (int x in int1) // running to each element of array            
            {
                b = true;
                if (x == 1)
                    b = false;
                for (int i = 2; i * i <= x; i++) //algorithm for checking elements are prime; 1,4
                {
                    if (x % i == 0) // if no remainder it is not prime
                    {
                        b = false; // so false
                    }
                }
                if (b) // if there are numbers well gone through algor. so it is prime 
                {
                    count++; // counts +1
                    res = res + " " + x; // will add prime numbers in empty string

                }
            }
            Console.WriteLine(count); //print out number of prime
            Console.WriteLine(res);
            Console.ReadKey();



            // чисто по стрингу
            //string n = Console.ReadLine(); // creating 
            //string line = Console.ReadLine(); // numbers as second line  1 2 3 4 5
            //string[] arr = line.Split(' '); // 'line' as array; each element is splitted by ' '
            //int k = 0; // epmty value for counting number of prime numbers
            //string res = ""; // empty string for result string
            //bool b;
            //foreach (var x in arr) // running to each element of array            
            //{
            //    b = true;
            //    int y = int.Parse(x); // t as number of elements in array
            //    if (y == 1)
            //        b = false;
            //    for (int i = 2; i * i <= y; i++) //algorithm for checking elements are prime; 1,4
            //    {
            //        if (y % i == 0) // if no remainder it is not prime
            //        {
            //            b = false; // so false
            //        }
            //    }
            //    if (b) // if there are numbers well gone through algor. so it is prime 
            //    {
            //        k++; // counts +1
            //        res = res + " " + x; // will add prime numbers in empty string

            //    }
            //}
            //Console.WriteLine(k); //print out number of prime
            //Console.WriteLine(res); // print out prime numbers
            //Console.ReadKey();

            // только по инт (не получилось)
            //int n = int.Parse(Console.ReadLine());
            //string line = Console.ReadLine();
            //string[] str = new string[n];
            //int[] int1 = new int[n];
            //str = line.Split();
            //for (int i = 0; i < n; i++)
            //{
            //    int1[i] = int.Parse(str[i]);
            //}

            //int count = 0;
            ////int[] int2;
            //int[] int2 = new int[100];
            //bool b;

            //for (int i = 0; i < n; i++)
            //{
            //    b = true;
            //    if (int1[i] == 1)
            //    {
            //        b = false;
            //    }
            //    for (int j = 2; j * j <= int1[i]; j++)
            //    {
            //        if (int1[i] % 2 == 0)
            //        {
            //            b = false;
            //        }
            //    }
            //    int k = 0;
            //    if (b)
            //    {
            //        count++;

            //        int2[k] = int1[i];
            //        k++;

            //    }
            //}
            //Console.WriteLine(count);
            //for (int k = 0; k < count; k++)
            //{
            //    Console.Write(int2[k] + " ");
            //}


            //Console.ReadKey();
        }

    }
}
