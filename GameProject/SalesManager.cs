using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class SalesManager : ISalesManager
    {
        public void Selling(Customer customer)
        {
            Console.WriteLine(customer.Name + " has bought the game.");
        }

        public void Selling(Customer customer, Campaign campaign)
        {
            Console.WriteLine(customer.Name + " has bought the game. Campaign= " + campaign.CampaignName);
        }
    }
}