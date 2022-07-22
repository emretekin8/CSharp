using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "emre", "alex" };


            string[,] regions = new string[3, 3]
            {
                { "İstanbul", "Balıkesir", "Kocaeli" },
                { "Ankara", "Konya", "Eskişehir" },
                { "Muğla", "İzmir", "Manisa" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }


            foreach (var item in regions)
            {
                Console.WriteLine(item);
            }
        }
    }
}
