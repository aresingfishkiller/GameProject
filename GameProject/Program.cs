using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Name = "Tuna", Surname = "Tezcan", CitizenshipNumber = "123456789", DateOfBirth = new DateTime(1993, 08, 10) };
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer);

            Customer customer2 = new Customer() { Name = "Buğra", Surname = "Çuhacı", CitizenshipNumber = "987654321", DateOfBirth = new DateTime(1995, 05, 04) };
            customerManager.Delete(customer2);


            CampaignManager campaignManager = new CampaignManager();
            SalesManager salesManager = new SalesManager();
            salesManager.Selling(customer, new Campaign { CampaignName = "Christmas" });

            campaignManager.UpdateCampaign(new Campaign { CampaignName = "Black Friday" });
            IGame game1 = new Game() { GameName = "RUST", ReleaseDate = new DateTime(2018, 02, 08) };
            GameManager gameManager = new GameManager();
            gameManager.AddGame(game1);
            gameManager.ChangePrice(game1);


        }
    }
}