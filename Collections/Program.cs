using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();

            //Dictionary();

            Console.ReadLine();
        }

        private static void Dictionary()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");

            Console.WriteLine(dictionary["Table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);       // ["Book", "Kitap]
                //Console.WriteLine(item.Value); // Book
                //Console.WriteLine(item.Key);   // Kitap
            }


            //bool 
            Console.WriteLine(dictionary.ContainsKey("Glass"));
            Console.WriteLine(dictionary.ContainsKey("Table"));
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList(); //like "var"

            cities.Add("Ankara");
            cities.Add("Adana");
            cities.Add(10);
            cities.Add('A');

            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
        }
    }
}
