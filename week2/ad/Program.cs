using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ad
{
    class Program
    {
        static bool IsPrime(int n)
        {
            if (n == 1)
            {
                return false ;
            }
            else
                for (int i = 0; i * i <= n; i++)
                {
                    if (n % 2 == 0) return false;
                    break;
                }

            
        }
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream("", FileMode.Open, FileAccess.Read))
            StreamReader 
        }
    }
}
