using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo.hw._3
{
    class CustomerManager
    {
        public void Add(Customer customer) 
        {
            Console.WriteLine("Hello! " + customer.NameSurname +" your id is: " + customer.Id);
        }

        public void Delete(Customer customer) 
        {
            Console.WriteLine("\nWe're sorry to lose you " + customer.NameSurname + " we have deleted your information!");
        }

        public void List(Customer[] customers) 
        {
            Console.WriteLine("\nCustomers\n");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Id + "  " + customer.NameSurname + "  " + customer.Quantity);
            }
        }

    }
}
