using System;

namespace ClassMethodDemo.hw._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 123456;
            customer1.NameSurname = "Berat Duran";
            customer1.Quantity = 120000;

            Customer customer2 = new Customer();
            customer2.Id = 234567;
            customer2.NameSurname = "Esra Duran";
            customer2.Quantity = 250000;

            Customer customer3 = new Customer();
            customer3.Id = 345678;
            customer3.NameSurname = "Aydın Duran";
            customer3.Quantity = 750000;

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new[] { customer1, customer2, customer3};

            foreach (Customer customer in customers)
            {
                customerManager.Add(customer);
            }

            customerManager.Delete(customer2);
            customerManager.List(customers);
        }

    }
}
