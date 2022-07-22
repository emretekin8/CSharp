using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int, long, short, byte, bool, char, double, decimal


            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)(Days.Friday));



        }
    }

    enum Days
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        // 1, 2, 3, 4, 5, 6... sorted
        // 1, 2, 40, 41, 42...
    }
}
