using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mathematics mathematics = new Mathematics(2, 3);
            //Console.WriteLine(mathematics.Add2());
            //Console.WriteLine(mathematics.Add(3, 4));

            var type = typeof(Mathematics);

            //Mathematics mathematics = (Mathematics)Activator.CreateInstance(type, 6, 7); // same with => Mathematics mathematics = new Mathematics(2, 3);
            //Console.WriteLine(mathematics.Add(4, 5)); 
            //Console.WriteLine(mathematics.Add2()); 

            var instance = Activator.CreateInstance(type, 6, 5);

            MethodInfo methodInfo = instance.GetType().GetMethod("Add2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("-------------------------------");

            var methods = type.GetMethods();

            foreach (var info in methods)
            {
                Console.WriteLine("Method name {0}", info.Name);
                foreach (var parameterInfo in info.GetParameters())
                {
                    Console.WriteLine("Parameter: {0}", parameterInfo.Name);

                }

                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name: {0}", attribute.GetType().Name);
                }
            }

            Console.ReadLine();
        }
    }

    class Mathematics
    {
        int _number1;
        int _number2;

        public Mathematics(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        [MethodName("Carpma")]
        public int Add2()
        {
            return _number1 + _number2;
        }

        public int Multiply2()
        {
            return _number2 * _number2;
        }

    }

    class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }

    }
}
