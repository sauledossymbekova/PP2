using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student // creating new class
    {
        public string Name;
        public int id;
        public int year;
        public Student(string n, int i, int y) //
        {
            Name = n;
            id = i;
            year = y;
        }
        public void Info() // the function prints data by 3 value
        {
            Console.WriteLine(Name + " " + id + " " + year);
        }
        public void Increment() // +1 to the year
        {
            year++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Name = Console.ReadLine(); // inputing line as student's name
            string id1 = Console.ReadLine(); // inp line as student's id
            int id = int.Parse(id1); // converting string id to the number
            string year1 = Console.ReadLine();  //inp line as student's year
            int year = int.Parse(year1); // year string>int

            Student S = new Student(Name, id, year); // calling to class with entered data
            S.Info(); // calling to Info function
            S.Increment(); // calling to Increment function
            S.Info(); // calling to Info Function
            Console.ReadKey();
        }
    }
}
