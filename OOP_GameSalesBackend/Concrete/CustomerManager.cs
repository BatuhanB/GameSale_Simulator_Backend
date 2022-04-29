using OOP_GameSalesBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Concrete
{
    class CustomerManager : ICustomerService
    {
        public void AddCustomer(Customer customer)
        {
            E_DevletAuth e_DevletAuth = new E_DevletAuth();

            List<Customer> customerAdd = new List<Customer>();

            e_DevletAuth.AuthCustomer(customer);
            customerAdd.Add(customer);
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurName + " has been successfully registered to the system!\n");
            Console.WriteLine("Customer:");
            Console.WriteLine("------------------------");
            Console.WriteLine("Customer id: " + customer.CustomerId + "\n" 
                + "Customer Name: " + customer.CustomerName + "\n" 
                + "Customer Surname: " + customer.CustomerSurName + "\n" 
                + "Customer Birth Date: " + customer.CustomerBirthDate + "\n" 
                + "Customer Id Number: " + customer.CustomerIdNumber);
            Console.WriteLine("------------------------");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurName + " has been successfully deleted from the system!\n");
        }

        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurName + " has been successfully updated!\n");
        }
    }
}
