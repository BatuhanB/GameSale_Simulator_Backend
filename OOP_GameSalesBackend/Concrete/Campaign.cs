using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GameSalesBackend.Concrete
{
    class Campaign
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int CampaignDiscountRate { get; set; }

        public Campaign()
        {

        }
        public Campaign(Campaign campaign)
        {
            this.CampaignId = campaign.CampaignId;
            this.CampaignName = campaign.CampaignName;
            this.CampaignDiscountRate = campaign.CampaignDiscountRate;
        }
    }
}
