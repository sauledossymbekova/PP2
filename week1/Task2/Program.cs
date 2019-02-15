using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name; //3 variables in the class student
        public string id;
        public string year;
        public Student() //constructor
        {
            name = Console.ReadLine(); //enter name
            id = Console.ReadLine(); //enter id
            year = Console.ReadLine(); //enter year
        }
        public void Info()
        {
            int Year = int.Parse(year); //convert to int
            Console.WriteLine($"Name: {name} ID: {id} Year: {Year}"); //prints as an example (Name: Saule ID: 18BD110362 Year:2018 )
            Year++; //increment
            Console.WriteLine($"Name: {name} ID: {id} Year: {Year}"); //prints as an example (Name: Saule ID: 18BD110362 Year:2019 )
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Info();
        }
    }
    }
