using OOP_GameSalesBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Concrete
{
    class E_DevletAuth : IAuthorizationService
    {
        public void AuthCustomer(Customer customer)
        {
            if (customer.CustomerId != 0 && customer.CustomerIdNumber.Length == 11
                && customer.CustomerName != "" && customer.CustomerSurName != "" && customer.CustomerBirthDate != "")
            {
                Console.WriteLine("| E-Devlet |\n");
                Console.WriteLine("Customer authorization has been successfully completed!");
            }
        }
    }
}
