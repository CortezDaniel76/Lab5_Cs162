using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace CustomerProductClasses
{
    public class CustomerList
    {
        private List<Customer> customers;

        public CustomerList()
        {
            customers = new List<Customer>();
        }

        public int Count => customers.Count;

        public Customer this[int index]
        {
            get => customers[index];
            set => customers[index] = value;
        }

        public Customer GetCustomerByEmail(string email)
        {
            return customers.FirstOrDefault(c => c.Email == email);
        }

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public void Add(int id, string firstName, string lastName, string email, string phoneNumber)
        {
            customers.Add(new Customer(id, firstName, lastName, email, phoneNumber));
        }

        public static CustomerList operator +(CustomerList list, Customer customer)
        {
            list.Add(customer);
            return list;
        }

        public void SaveToFile(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, customers);
            }
        }

        public void LoadFromFile(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            using (StreamReader reader = new StreamReader(filename))
            {
                customers = (List<Customer>)serializer.Deserialize(reader);
            }
        }

        public void Remove(Customer customer)
        {
            customers.Remove(customer);
        }

        public static CustomerList operator -(CustomerList list, Customer customer)
        {
            list.Remove(customer);
            return list;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, customers);
        }
    }
}
