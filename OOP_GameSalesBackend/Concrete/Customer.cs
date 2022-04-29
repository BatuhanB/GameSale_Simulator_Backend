using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Concrete
{
    class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurName { get; set; }
        public string CustomerIdNumber { get; set; }
        public string CustomerBirthDate { get; set; }

        public Customer()
        {

        }
        public Customer(Customer customer)
        {
            this.CustomerId = customer.CustomerId;
            this.CustomerName = customer.CustomerName;
            this.CustomerSurName = customer.CustomerSurName;
            this.CustomerIdNumber = customer.CustomerIdNumber;
            this.CustomerBirthDate = customer.CustomerBirthDate;
        }
    }
}
