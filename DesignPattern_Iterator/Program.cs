using System;

namespace DesignPattern_Iterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Employee("Dave", 100));
            collection.AddEmployee(new Employee("Angie", 101));
            collection.AddEmployee(new Employee("Mark", 102));
            collection.AddEmployee(new Employee("Chris", 103));
            collection.AddEmployee(new Employee("Keith", 104));
            collection.AddEmployee(new Employee("Joe", 105));

            // Create iterator
            Iterator iterator = collection.CreateIterator();
            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}
