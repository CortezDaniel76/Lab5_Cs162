using System;
using CustomerProductClasses;

namespace CustomerProductTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCustomerList();
        }

        static void TestCustomerList()
        {
            CustomerList customerList = new CustomerList();
            Console.WriteLine("Testing CustomerList class");

            Customer c1 = new Customer(1, "John", "Doe", "john.doe@example.com", "123-456-7890");
            Customer c2 = new Customer(2, "Jane", "Smith", "jane.smith@example.com", "987-654-3210");

            // Test Add(Customer)
            customerList.Add(c1);
            customerList.Add(c2);

            // Test Count
            Console.WriteLine("Customer count (Expecting 2): " + customerList.Count);

            // Test indexer
            Console.WriteLine("First customer (Expecting John Doe): " + customerList[0]);

            // Test GetCustomerByEmail
            Console.WriteLine("Get customer by email (Expecting Jane Smith): " + customerList.GetCustomerByEmail("jane.smith@example.com"));

            // Test Add(int, string, string, string, string)
            customerList.Add(3, "Bob", "Johnson", "bob.johnson@example.com", "555-555-5555");

            // Test operator +
            Customer c4 = new Customer(4, "Alice", "Williams", "alice.williams@example.com", "444-444-4444");
            customerList += c4;

            // Test SaveToFile and LoadFromFile
            string filename = "customers.xml";
            customerList.SaveToFile(filename);

            CustomerList loadedList = new CustomerList();
            loadedList.LoadFromFile(filename);
            Console.WriteLine("Loaded customer list from file (Expecting 4 customers):");
            Console.WriteLine(loadedList);

            // Test Remove(Customer)
            customerList.Remove(c1);

            // Test operator -
            customerList -= c2;
            Console.WriteLine("Customer list after removing two customers (Expecting 2 customers):");
            Console.WriteLine(customerList);

            // Test ToString
            Console.WriteLine("Customer list (Expecting remaining customers):");
            Console.WriteLine(customerList);
        }
    }
}
