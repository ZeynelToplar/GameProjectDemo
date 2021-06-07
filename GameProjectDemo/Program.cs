using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game'lerin oluşturuldu kısım 
            Game game1 = new Game
            {
                GameName = "Last Of Us 2",
                GameCategory = "Hayatta Kalma",
                GamePrice = 250
            };
            Game game2 = new Game
            {
                GameName = "Uncharted 4",
                GameCategory = "Macera",
                GamePrice = 350
            };
            Game game3 = new Game
            {
                GameName = "God Of War",
                GameCategory = "Aksiyon, Dövüş",
                GamePrice = 450
            };

            //Kampanyaların Oluşturulduğ Kısım 
            Campaigns campaign1 = new Campaigns();
            campaign1.CampaignName = "Yaz İndirimi";
            campaign1.CampaignDiscount = 50;

            Campaigns campaign2 = new Campaigns();
            campaign2.CampaignName = "Haftasonu İndirimi";
            campaign2.CampaignDiscount = 25;


            //Gamer'ların oluşturuluğu kısım
            Gamer gamer1 = new Gamer
            {
                FirstName = "Engin ",
                LastName = "Demiroğ",
                NationalityId = "12345678910",
                DateOfBirth = new DateTime(1985, 1, 6)
            };
            Gamer gamer2 = new Gamer
            {
                FirstName = "Zeynel ",
                LastName = "Toplar",
                NationalityId = "10987654321",
                DateOfBirth = new DateTime(1998, 10, 20)
            };

            //Gamer'ların yönetildiği kısım (Add, Update, Delete)
            GamerManager gamerManager = new GamerManager(new VerificationManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer1);

            Console.WriteLine("************************");

            //Game'lerin yönetildiği kısım 
            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            Console.WriteLine("-------------------------");


            gameManager.Add(game2);

            Console.WriteLine("************************");

            //Kampanyaların yönetildiği kısım 
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("************************");

            //Oyun satışlarının yönetildiği kısım. 
            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(gamer1, game1,campaign1);

            Console.WriteLine("************************");

            gameSaleManager.Sale(gamer2, game3, campaign2);


            

            

            Console.ReadLine();
        }
    }
}
