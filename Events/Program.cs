using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product screen = new Product(50);
            screen.ProductName = "SCREEN";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += GsmStockControlEvent;

            for (int i = 0; i < 10; i++)    
            {
                screen.Sell(10);
                gsm.Sell(5);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void GsmStockControlEvent()
        {
            Console.WriteLine("GSM about to finish!!!");
        }
    }
}
