using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.List();

            Product product1 = new Product { Id = 1, Name = "Table" };
            Product product2 = new Product(2, "Laptop");

            Console.WriteLine("{0} {1}", product1.Name, product2.Name);



            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            Teacher.Number = 10;
            Console.WriteLine("Teacher number: {0}", Teacher.Number);


            Utilities.Validate();



            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 14;      


        public CustomerManager(int count)
        {
            _count = count;
        }

        //overloading
        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    class Product
    {
        private int _id;
        private string _name;

        public Product()
        {

        }

        public Product(int id, string name)
        {
            _id = id;
            _name = name;

            Id = id;
            Name = name;

        }
        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;

        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    static class Teacher
    {
        public static int Number { get; set; }

    }

    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
}
