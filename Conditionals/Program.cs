using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = 411;


            //if
            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is ranged in 0-100");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Number is ranged in 101-200");
            }
            else
            {
                Console.WriteLine("Unknown");
            }

             
            //switch-case
            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }


        }
    }
}
