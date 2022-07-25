using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    public delegate int MyDelegate3(int number1, int number2);

    internal class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();


            MyDelegate myDelegate1 = null;
            myDelegate1 += customerManager.SendMessage;
            myDelegate1 += customerManager.ShowAlert;
            //myDelegate-=customerManager.SendMessage;
            myDelegate1();


            MyDelegate2 myDelegate2 = null;
            myDelegate2 += customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello2");


            Mathematics mathematics = new Mathematics();

            MyDelegate3 myDelegate3 = null;
            myDelegate3 += mathematics.Add;
            myDelegate3 += mathematics.Multiply;

            var result = myDelegate3(2, 3);
            Console.WriteLine(result);



            Console.ReadLine();
        }
    }

    public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello!");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }

    public class Mathematics
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
