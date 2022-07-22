using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseManager = new CourseManager();
            courseManager.Add();


            Console.ReadLine();
        }
    }


    class Customer
    {
        private int Id { get; set; }
        protected int Name { get; set; } // able to access in inherited classes

        public void Save()
        {

        }

        public void Delete()
        {

        }
    }

    class Student : Customer
    {
        public void Save()
        {
            Customer customer = new Customer();
            Console.WriteLine("Student class is working.");

        }
    }

    internal class Course // able to use without referance
    {
        public int Name { get; set; }

        public void Add()
        {
            Console.WriteLine("Course class is working.");
        }
    }

    public class Demo // "public" is able to use in another project
    {
        public int Id { get; set; }
    }
}
