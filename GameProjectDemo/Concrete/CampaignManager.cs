using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanyası eklendi.");
            Console.WriteLine("Kampanya İndirimi : %" + campaign.CampaignDiscount);
        }

        public void Delete(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + "kampanya kaldırıldı.");
        }

        public void Update(Campaigns campaign)
        {
            Console.WriteLine(campaign.CampaignName + " kampanya güncellendi.");
            Console.WriteLine("Güncel Kampanya indirimi : %" + campaign.CampaignDiscount);
        }
    }
}
