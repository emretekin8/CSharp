using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 5, 45, 78, 48, 2, 5, 6, 9, 8, 7)); 
        }

        //method with "params" keyword
        static int Add(params int[] numbers)
        {
            return numbers.Sum();
        }

    }
}
