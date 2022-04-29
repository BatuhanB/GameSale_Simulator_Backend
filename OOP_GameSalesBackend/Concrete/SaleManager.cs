using OOP_GameSalesBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Concrete
{
    class SaleManager : ISaleService
    {
        public void SaleProcess(Customer customer, Campaign campaign)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Game has been successfully sold to " + customer.CustomerName + " " + customer.CustomerSurName + " in " + campaign.CampaignName + "%" + campaign.CampaignDiscountRate);
        }

        public void SaleRefund(Customer customer, Campaign campaign)
        {
            Console.WriteLine("Game has been successfully refunded from " + customer.CustomerName + customer.CustomerSurName + " within " + campaign.CampaignName);
        }
    }
}
