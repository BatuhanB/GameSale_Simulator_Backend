using OOP_GameSalesBackend.Concrete;
using System;

namespace OOP_GameSalesBackend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Batuhan";
            customer1.CustomerSurName = "Balı";
            customer1.CustomerBirthDate = "1999";
            customer1.CustomerIdNumber = "11111111111";

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Dev İndirim!";
            campaign1.CampaignDiscountRate = 25;

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.NewCampaign(campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.SaleProcess(customer1, campaign1);

        }
    }
}
