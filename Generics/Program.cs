using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "İzmir", "Adana");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer("Emre"), new Customer("Eden"));

            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product : IEntity
    {

    }

    interface IProductDal : IRepository<Product>
    {

    }

    class Customer : IEntity
    {
        public Customer(string firstName)
        {
            FirstName = firstName;
        }

        public string FirstName { get; set; }
    }

    interface ICustomerDal : IRepository<Student>
    {

    }

    class Student : IEntity
    {

    }

    interface IEntity
    {

    }

    interface IRepository<T> where T :/*struct*/ class, IEntity, new() //==> T can only be a reference type && implemented by an interface && can be constructed ( X = new blabla(); )
    {                                 //struct means is able to only value types => int, double..  
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }

    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal
    {
        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }


}
