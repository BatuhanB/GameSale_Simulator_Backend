using OOP_GameSalesBackend.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Campaign has been successfully deleted!");
        }

        public void NewCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " " + campaign.CampaignDiscountRate + "% campaign has been successfully added!");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "Campaign has been successfully updated!");
        }
    }
}
