using OOP_GameSalesBackend.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Abstract
{
    interface ISaleService
    {
        void SaleProcess(Customer customer, Campaign campaign);
        void SaleRefund(Customer customer, Campaign campaign);
    }
}
