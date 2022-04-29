using OOP_GameSalesBackend.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Abstract
{
    interface IAuthorizationService
    {
        void AuthCustomer(Customer customer);
    }
}
